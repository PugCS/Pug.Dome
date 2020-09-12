
using Pug.Application.Data;

using Pug.Application.Security;

using Pug.Effable;

namespace Pug.Dome
{
    public abstract class CreatableEntity<TDataStore, TInfo, TIdentifier, TEntityVersionUser> 
        : Entity<TDataStore, TInfo, TIdentifier/*, TEntityVersionUser*/>
        where TDataStore : class, IApplicationDataSession
        where TInfo : IEntityInfo<TIdentifier/*, TEntityVersionUser*/>
    {

        protected CreatableEntity(TIdentifier identifier, IApplicationData<TDataStore> dataProviderFactory, ISecurityManager securityManager) 
            : base(identifier, dataProviderFactory, securityManager)
        {
        }

        public abstract ICreationInfo<TEntityVersionUser> CreationInfo { get; }
    }
}
