using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Pug.Application.Data;
using Pug.Application.Security;

namespace Pug.Dome
{
	public abstract class UpdatableRegisteredEntity<DS, INF, I, EVU> : RegisteredEntity<DS, INF, I, EVU>, IUpdatableEntity<INF, I, EVU>
		where DS : IApplicationDataSession
		where INF : IUpdatableEntityInfo<I, EVU>
	{
		protected UpdatableRegisteredEntity(INF info, IApplicationData<DS> dataProviderFactory, ISecurityManager securityManager)
			: base(info, dataProviderFactory, securityManager)
		{
		}
	}

	//public abstract class UpdatableRegisteredEntity<DS, INF, EVU> : UpdatableRegisteredEntity<DS, INF, string, EVU>//, IUpdatableEntity<INF, string, EVU>
	//	where DS : IApplicationDataSession
	//	where INF : IUpdatableEntityInfo<string, EVU>
	//{
	//}

	//public abstract class UpdatableEntity<DS, INF, I, EVU> : Entity<DS, INF, I>, IUpdatableEntity<INF, I, EVU>
	//	where DS : IApplicationDataSession
	//	where INF : IUpdatableEntityInfo<I, EVU>
	//{
	//}

	//public abstract class UpdatableEntity<DS, INF> : Entity<DS, INF, string>, IEntity<INF, string>, IUpdatableEntity<INF, string, string>
	//	where DS : IApplicationDataSession
	//	where INF : IUpdatableEntityInfo<string, string>
	//{
	//}
}
