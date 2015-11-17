using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public abstract class EntityInfo<TIdentifier, TEntityVersionUser> : IEntityInfo<TIdentifier, TEntityVersionUser>
	{
		TEntityVersionUser createUser;
		DateTime createTimestamp;
		TEntityVersionUser registrationUser;
		DateTime registrationTimestamp;

		public EntityInfo(TIdentifier identifier, TEntityVersionUser registrationUser, DateTime registrationTimestamp, TEntityVersionUser createUser, DateTime createTimestamp)
		{
			this.Identifier = identifier;
			this.createUser = createUser;
			this.createTimestamp = createTimestamp;
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

		public TEntityVersionUser CreateUser
		{
			get
			{
				return createUser;
			}
		}

		public DateTime CreateTimestamp
		{
			get
			{
				return createTimestamp;
            }
		}
	}
}
