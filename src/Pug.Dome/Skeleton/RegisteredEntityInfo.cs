using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public abstract class RegisteredEntityInfo<tIdentifier, tEntityVersionUser> 
		: EntityInfo<tIdentifier>, IRegisteredInfo<tEntityVersionUser>
	{
		public RegisteredEntityInfo(tIdentifier identifier, DateTime registrationTimestamp, tEntityVersionUser registrationUser)
			: base(identifier)
		{
			RegistrationTimestamp = registrationTimestamp;
			RegistrationUser = registrationUser;
		}

		public tEntityVersionUser RegistrationUser { get; protected set; }

		public DateTime RegistrationTimestamp { get; protected set; }
	}

	//public abstract class RegisteredEntityInfo : RegisteredEntityInfo<string, string>
	//{
	//	public RegisteredEntityInfo(string identifier, DateTime registrationTimestamp, string registrationUser)
	//		: base(identifier, registrationTimestamp, registrationUser)
	//	{
	//	}
	//}
}
