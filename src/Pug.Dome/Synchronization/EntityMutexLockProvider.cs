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

		struct LockInfo
		{
			public Mutex Lock;
			public DateTime TimeStamp;

			public void Release()
			{
				Lock.ReleaseMutex();
				Lock.Close();
			}
		}

		string scopePrefix = @"Local\";
		string identifier;

		IEntityIdentifierAuthority identifierAuthority;

		readonly Dictionary<string, LockInfo> locks;
		Timer cleanupTimer;

		readonly object disposeSync = new object();

		public EntityMutexLockProvider(string identifier, Scope scope, IEntityIdentifierAuthority identifierAuthority)
		{
			this.identifier = identifier;

			if (scope == Scope.Global)
				scopePrefix = @"Global\";

			this.identifierAuthority = identifierAuthority;
			locks = new Dictionary<string, LockInfo>();
			cleanupTimer = new Timer(new TimerCallback(Cleanup), null, 5000, 5000);
		}

		void Cleanup(object state)
		{
			string[] lockKeys = locks.Keys.ToArray();

			LockInfo lockInfo;

			foreach (string key in lockKeys)
			{
				if (locks.TryGetValue(key, out lockInfo))
					if (DateTime.Now.Subtract(lockInfo.TimeStamp).TotalSeconds >= 30)
					{
						lockInfo.Release();
					}

				locks.Remove(key);
			}
		}

		string GetMutexIdentifier(string entity)
		{
			StringBuilder mutexIdentifier = new StringBuilder(scopePrefix);
			mutexIdentifier.Append(this.identifier);
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
				token = identifierAuthority.GetIdentifier(string.Empty);
				locks.Add(token, new LockInfo() { Lock = mutex, TimeStamp = DateTime.Now });
			}

			return token;
		}

		public void Release(string @lock)
		{
			LockInfo lockInfo;

			if( locks.TryGetValue(@lock, out lockInfo))
			{
				lockInfo.Release();
				locks.Remove(@lock);
			}
		}

		public void Dispose()
		{
			lock (disposeSync)
			{
				if (cleanupTimer == null)
					return;

				cleanupTimer.Dispose();

				cleanupTimer = null;
			}

			LockInfo lockInfo;

			foreach (string key in this.locks.Keys)
			{
				if (this.locks.TryGetValue(key, out lockInfo))
				{
					lockInfo.Release();
				}
			}
		}
	}
}
