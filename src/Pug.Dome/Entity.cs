
using Pug.Application.Data;

using Pug.Application.Security;

using Pug.Effable;

namespace Pug.Dome
{
	public abstract class Entity<TDataStore, TIdentifier> : IEntity<TIdentifier> 
		where TDataStore : class, IApplicationDataSession
	{
		private readonly TIdentifier _identifier;

		private readonly IApplicationData<TDataStore> _dataProviderFactory;
		private readonly ISecurityManager _securityManager;
		
		protected Entity(TIdentifier identifier, IApplicationData<TDataStore> dataProviderFactory, ISecurityManager securityManager)
		{
			_identifier = identifier;
			_dataProviderFactory = dataProviderFactory;
			_securityManager = securityManager;
		}

		public TIdentifier Identifier
		{
			get
			{
				return _identifier;
			}
		}


		protected IApplicationData<TDataStore> DataProviderFactory
		{
			get
			{
				return _dataProviderFactory;
			}
		}

		protected ISecurityManager SecurityManager
		{
			get
			{
				return _securityManager;
			}
        }
        protected IUser User => SecurityManager.CurrentUser;
	}
	
	public abstract class Entity<TDataStore, TInfo, TIdentifier> : Entity<TDataStore, TIdentifier>, IEntity<TInfo, TIdentifier> 
		where TDataStore : class, IApplicationDataSession
		where TInfo : IEntityInfo<TIdentifier>
	{
		protected Entity(TIdentifier identifier, IApplicationData<TDataStore> dataProviderFactory, ISecurityManager securityManager)
		 : base (identifier, dataProviderFactory, securityManager)
		{
		}

		public abstract TInfo GetInfo();
	}
}
