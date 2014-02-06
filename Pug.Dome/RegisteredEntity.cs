using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Pug.Application.Data;
using Pug.Application.Security;

namespace Pug.Dome
{
	public abstract class RegisteredEntity<DS, INF, I, EVU> : Entity<DS, INF, I>
		where DS : IApplicationDataSession
		where INF : IRegisteredEntityInfo<I, EVU>
	{
		protected RegisteredEntity(INF info, IApplicationData<DS> dataProviderFactory, ISecurityManager securityManager)
			: base(info, dataProviderFactory, securityManager)
		{
		}
	}

	//public abstract class RegisteredEntity<DS, INF, EVU> : RegisteredEntity<DS, INF, string, EVU>//, IRegisteredEntityInfo<string, EVU>
	//	where DS : IApplicationDataSession
	//	where INF : IEntityInfo<string>
	//{
	//}
}
