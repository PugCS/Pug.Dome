using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Effable
{
	public abstract class EntityInfo<TIdentifier/*, TEntityVersionUser*/> : IEntityInfo<TIdentifier/*, TEntityVersionUser*/>
	{
		TIdentifier identifier;

		public EntityInfo()
		{
			
		}

		protected EntityInfo(TIdentifier identifier)
		{
			this.identifier = identifier;
		}

		public TIdentifier Identifier
		{ 
			get { return this.identifier; }
			protected set { this.identifier = value; }
		}
	}
}
