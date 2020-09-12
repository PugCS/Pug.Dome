
using Pug.Application.Data;

using Pug.Application.Security;

using Pug.Effable;

namespace Pug.Dome
{
	public abstract class Entity<TDataStore, TInfo, TIdentifier/*, TEntityVersionUser*/> : IEntity<TInfo, TIdentifier/*, TEntityVersionUser*/> 
		where TDataStore : class, IApplicationDataSession
		where TInfo : IEntityInfo<TIdentifier/*, TEntityVersionUser*/>
	{
		readonly TIdentifier identifier;

		readonly IApplicationData<TDataStore> dataProviderFactory;
		readonly ISecurityManager securityManager;
		
		protected Entity(TIdentifier identifier, IApplicationData<TDataStore> dataProviderFactory, ISecurityManager securityManager)
		{
			this.identifier = identifier;
			this.dataProviderFactory = dataProviderFactory;
			this.securityManager = securityManager;
		}

		public TIdentifier Identifier
		{
			get
			{
				return this.identifier;
			}
		}


		protected IApplicationData<TDataStore> DataProviderFactory
		{
			get
			{
				return dataProviderFactory;
			}
		}

		protected ISecurityManager SecurityManager
		{
			get
			{
				return securityManager;
			}
        }
        protected IUser User => SecurityManager.CurrentUser;

        public abstract TInfo GetInfo();
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
