using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public abstract class EntityInfo<TIdentifier, TEntityVersionUser> : IEntityInfo<TIdentifier, TEntityVersionUser>
	{
		TEntityVersionUser registrationUser;
		DateTime registrationTimestamp;

		public EntityInfo(TIdentifier identifier, TEntityVersionUser registrationUser, DateTime registrationTimestamp)
		{
			this.Identifier = identifier;
			this.registrationUser = registrationUser;
			this.registrationTimestamp = registrationTimestamp;
		}

		public virtual TIdentifier Identifier { get; protected set; }

		public DateTime RegistrationTimestamp
		{
			get
			{
				return this.registrationTimestamp;
			}
		}

		public TEntityVersionUser RegistrationUser
		{
			get
			{
				return this.registrationUser;
			}
		}
	}
}
