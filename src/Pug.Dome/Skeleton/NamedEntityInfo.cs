using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public abstract class NamedEntityInfo<TIdentifier, TName, TEntityVersionUser> : EntityInfo<TIdentifier, TEntityVersionUser>, INamedEntityInfo<TIdentifier, TName, TEntityVersionUser>
	{
		public NamedEntityInfo(TIdentifier identifier, TName name, TEntityVersionUser registrationUser, DateTime registrationTimestamp)
			: base(identifier, registrationUser, registrationTimestamp)
		{
			this.Name = name;
		}

		public TName Name
		{
			get;
			protected set;
		}
	}
}
