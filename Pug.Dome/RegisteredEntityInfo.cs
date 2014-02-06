using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public abstract class RegisteredEntityInfo<I, EVU> : EntityInfo<I>, IRegisteredEntityInfo<I, EVU>
	{
		public RegisteredEntityInfo(I identifier, DateTime registrationTimestamp, EVU registrationUser)
			: base(identifier)
		{
			RegistrationTimestamp = registrationTimestamp;
			RegistrationUser = registrationUser;
		}

		public EVU RegistrationUser { get; protected set; }

		public DateTime RegistrationTimestamp { get; protected set; }
	}

	public abstract class RegisteredEntityInfo : RegisteredEntityInfo<string, string>
	{
		public RegisteredEntityInfo(string identifier, DateTime registrationTimestamp, string registrationUser)
			: base(identifier, registrationTimestamp, registrationUser)
		{
		}
	}
}
