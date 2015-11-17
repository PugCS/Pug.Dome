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

		Dictionary<string, LockInfo> locks;
		Timer cleanupTimer;

		object disposeSync = new object();

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
			string[] locks = this.locks.Keys.ToArray();

			LockInfo lockInfo;

			foreach (string identifier in locks)
			{
				if (this.locks.TryGetValue(identifier, out lockInfo))
					if (DateTime.Now.Subtract(lockInfo.TimeStamp).TotalSeconds >= 30)
					{
						lockInfo.Release();
					}

				this.locks.Remove(identifier);
			}
		}

		string GetMutexIdentifier(string identfiier)
		{
			StringBuilder mutexIdentifier = new StringBuilder(scopePrefix);
			mutexIdentifier.Append(this.identifier);
			mutexIdentifier.Append(".");
			mutexIdentifier.Append(identifier);

			return mutexIdentifier.ToString();
		}

		public string Lock(string identifier)
		{
			return Lock(identifier, 0);
		}

		public string Lock(string identifier, int timeout)
		{
			bool locked = false;
			string mutexIdentifier;

			Mutex mutex = new Mutex(true, mutexIdentifier = GetMutexIdentifier(identifier), out locked);

			if (!locked)
				locked = mutex.WaitOne(timeout);

			string token = string.Empty;

			if (locked)
			{
				token = identifierAuthority.GetIdentifier(string.Empty);
				locks.Add(token, new LockInfo() { Lock = mutex, TimeStamp = DateTime.Now });
			}

			return token;
		}

		public void Release(string identifier)
		{
			LockInfo lockInfo;

			if( locks.TryGetValue(identifier, out lockInfo))
			{
				lockInfo.Release();
				locks.Remove(identifier);
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

			foreach (string identifier in this.locks.Keys)
			{
				if (this.locks.TryGetValue(identifier, out lockInfo))
				{
					lockInfo.Release();
				}
			}
		}
	}
}
