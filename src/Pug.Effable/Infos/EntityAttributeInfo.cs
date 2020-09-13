using System;

namespace Pug.Effable
{
	public class EntityAttributeInfo<TKey, TValue> : IEntityAttributeInfo<TKey, TValue>
	{
		TKey name;
		TValue value;

		public EntityAttributeInfo()
		{
			
		}

		public EntityAttributeInfo(TKey name, TValue value)
		{
			this.name = name;
			this.value = value;
		}

		public TKey Name
		{
			get { return name; }
			set { this.name = value;  }
		}

		public TValue Value
		{
			get { return value; }
			set { this.value = value; }
		}
	}
}
