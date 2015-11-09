﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Pug.Application.Security;
using Pug.Application.Data;

namespace Pug.Dome
{
	public abstract class RegisteredEntity<tDataSession, tInfo, tIdentifier, tVersionUser> 
		: Entity<tDataSession, tInfo, tIdentifier>
		where tDataSession : class, IApplicationDataSession
		where tInfo : IEntityInfo<tIdentifier>, IRegisteredInfo<tVersionUser>
	{
		protected RegisteredEntity(tInfo info, IApplicationData<tDataSession> dataProviderFactory, ISecurityManager securityManager)
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
