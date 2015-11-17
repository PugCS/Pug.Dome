using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using System.Transactions;

using Pug.Application.Data;

using Pug.Application.Security;

namespace Pug.Dome
{
	public abstract class Entity<DS, INF, I> : IEntity<INF, I> 
		where DS : class, IApplicationDataSession
		where INF : IEntityInfo<I>
	{
		readonly IApplicationData<DS> dataProviderFactory;
		readonly ISecurityManager securityManager;

		protected Entity(INF info, IApplicationData<DS> dataProviderFactory, ISecurityManager securityManager)
		{
			this.dataProviderFactory = dataProviderFactory;
			this.securityManager = securityManager;
		}

		protected IApplicationData<DS> DataProviderFactory
		{
			get
			{
				return dataProviderFactory;
			}
		}

		protected void dbx(Action<DS> action, TransactionScopeOption transactionScopeOption = TransactionScopeOption.Required, Action<Exception> onError = null, Action<Exception> errorHandler = null, Action onFinished = null)
		{
			DS dataSession = default(DS);

			try
			{
				dataSession = DataProviderFactory.GetSession();

				using (new TransactionScope(transactionScopeOption))
				{
					action(dataSession);
				}
			}
			catch (Exception exception)
			{
				if (onError != null)
					onError(exception);

				if (errorHandler == null)
					throw;

				errorHandler(exception);
			}
			finally
			{
				if (dataSession != null)
					dataSession.Dispose();

				if (onFinished != null)
					onFinished();
			}
		}

		protected ISecurityManager SecurityManager
		{
			get
			{
				return securityManager;
			}
		}

		public virtual INF Info { get; protected set; }

		public abstract void Refresh();
	}

	//public abstract class Entity<DS, INF> : Entity<DS, INF, string>
	//	where DS : IApplicationDataSession
	//	where INF : IEntityInfo<string>
	//{
	//	protected Entity(INF info, IApplicationData<DS> dataProviderFactory, ISecurityManager securityManager)
	//		: base(info, dataProviderFactory, securityManager)
	//	{
	//	}
	//}
}
