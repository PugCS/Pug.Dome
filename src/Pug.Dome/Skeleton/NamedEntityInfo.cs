using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public abstract class NamedEntityInfo<TIdentifier, TName> : EntityInfo<TIdentifier/*, TEntityVersionUser*/>, INamedEntityInfo<TIdentifier, TName/*, TEntityVersionUser*/>
	{
		protected NamedEntityInfo(TIdentifier identifier, TName name/*, TEntityVersionUser registrationUser, DateTime registrationTimestamp, TEntityVersionUser createUser, DateTime createTimestamp*/)
			: base(identifier/*, registrationUser, registrationTimestamp, createUser, createTimestamp*/)
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
