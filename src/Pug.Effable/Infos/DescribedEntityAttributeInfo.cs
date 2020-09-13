using System;

namespace Pug.Effable
{
	public class DescribedEntityAttributeInfo<TKey, TValue, TDescription /*, TEntityVersionUser*/> : EntityAttributeInfo<TKey, TValue /*, TEntityVersionUser*/>, IDescribedEntityAttributeInfo<TKey, TValue, TDescription /*, TEntityVersionUser*/>
	{
		public DescribedEntityAttributeInfo()
		{
			
		}
		
		public DescribedEntityAttributeInfo(TKey name, TValue value, TDescription description)
			: base(name, value)
		{
			this.Description = description;
		}

		public TDescription Description { get; set; }
	}
}
