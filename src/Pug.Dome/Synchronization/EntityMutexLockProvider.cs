using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;

namespace Pug.Dome.Synchronization
{
	public class EntityMutexLockProvider : IEntityLockProvider, IDisposable
	{
		public enum Scope
		{
			Local,
			Global
		}

		private class LockInfo
		{
			public Mutex Lock;
			public DateTime TimeStamp;

			public void Release()
			{
				Lock.ReleaseMutex();
				Lock.Dispose();
			}
		}

		private string _scopePrefix = @"Local\";
		private string _identifier;

		private IEntityIdentifierAuthority _identifierAuthority;

		private readonly Dictionary<string, LockInfo> _locks;
		private Timer _cleanupTimer;

		private readonly object _disposeSync = new object();

		public EntityMutexLockProvider(string identifier, Scope scope, IEntityIdentifierAuthority identifierAuthority)
		{
			_identifier = identifier;

			if (scope == Scope.Global)
				_scopePrefix = @"Global\";

			_identifierAuthority = identifierAuthority;
			_locks = new Dictionary<string, LockInfo>();
			_cleanupTimer = new Timer(new TimerCallback(Cleanup), null, 5000, 5000);
		}

		private void Cleanup(object state)
		{
			string[] lockKeys = _locks.Keys.ToArray();

			LockInfo lockInfo;

			foreach (string key in lockKeys)
			{
				if (_locks.TryGetValue(key, out lockInfo))
					if (DateTime.Now.Subtract(lockInfo.TimeStamp).TotalSeconds >= 30)
					{
						lockInfo.Release();
					}

				_locks.Remove(key);
			}
		}

		private string GetMutexIdentifier(string entity)
		{
			StringBuilder mutexIdentifier = new StringBuilder(_scopePrefix);
			mutexIdentifier.Append(_identifier);
			mutexIdentifier.Append(".");
			mutexIdentifier.Append(entity);

			return mutexIdentifier.ToString();
		}

		public string Lock(string entity)
		{
			return Lock(entity, 0);
		}

		public string Lock(string entity, int timeout)
		{
			bool locked = false;
			string mutexIdentifier;

			Mutex mutex = new Mutex(true, mutexIdentifier = GetMutexIdentifier(entity), out locked);

			// wait for mutex if not owned
			if (!locked)
				locked = mutex.WaitOne(timeout);

			// return null if unable to lock mutex within specified time-out
			if (!locked)
				return null;

			string token = string.Empty;

			if (locked)
			{
				token = _identifierAuthority.GetIdentifier(string.Empty);
				_locks.Add(token, new LockInfo() { Lock = mutex, TimeStamp = DateTime.Now });
			}

			return token;
		}

		public void Release(string @lock)
		{
			LockInfo lockInfo;

			if( _locks.TryGetValue(@lock, out lockInfo))
			{
				lockInfo.Release();
				_locks.Remove(@lock);
			}
		}

		public void Dispose()
		{
			lock (_disposeSync)
			{
				if (_cleanupTimer == null)
					return;

				_cleanupTimer.Dispose();

				_cleanupTimer = null;
			}

			LockInfo lockInfo;

			foreach (string key in _locks.Keys)
			{
				if (_locks.TryGetValue(key, out lockInfo))
				{
					lockInfo.Release();
				}
			}
		}
	}
}
