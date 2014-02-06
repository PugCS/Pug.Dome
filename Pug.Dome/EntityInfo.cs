using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public abstract class EntityInfo<I> : IEntityInfo<I>
	{

		public EntityInfo(I identifier)
		{
			this.Identifier = identifier;
		}

		public virtual I Identifier { get; protected set; }
	}
}
