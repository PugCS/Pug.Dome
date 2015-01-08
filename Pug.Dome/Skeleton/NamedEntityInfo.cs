using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public abstract class NamedEntityInfo<tIdentifier, tName> : EntityInfo<tIdentifier>, INamed<tName>
	{
		public NamedEntityInfo(tIdentifier identifier, tName name)
			: base(identifier)
		{
			this.Name = name;
		}

		public tName Name
		{
			get;
			protected set;
		}
	}
}
