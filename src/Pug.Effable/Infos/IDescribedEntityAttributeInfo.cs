using System;

namespace Pug.Effable
{
	public interface IDescribedEntityAttributeInfo<out TKey, TValue, TDescription /*, out TEntityVersionUser*/> : IEntityAttributeInfo<TKey, TValue/*, TEntityVersionUser*/>, IDescribedInfo<TDescription>
	{
	}
}