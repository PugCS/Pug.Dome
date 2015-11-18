using System;

namespace Pug.Dome
{
	public class DescribedEntityAttributeInfo<TKey, TValue, TEntityVersionUser> : EntityAttributeInfo<TKey, TValue, TEntityVersionUser>, IDescribedEntityAttributeInfo<TKey, TValue, TEntityVersionUser>
	{
		public DescribedEntityAttributeInfo(TKey name, TValue value, string description, DateTime specificationTimestamp, TEntityVersionUser specificationUser, DateTime createTimestamp, TEntityVersionUser createUser)
			: base(name, value, specificationTimestamp, specificationUser, createTimestamp, createUser)
		{
			this.Description = description;
		}

		public string Description { get; protected set; }
	}
}
