using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public abstract class EntityInfo<tIdentifier> : IEntityInfo<tIdentifier>
	{
		public EntityInfo(tIdentifier identifier)
		{
			this.Identifier = identifier;
		}

		public virtual tIdentifier Identifier { get; protected set; }
	}
}
