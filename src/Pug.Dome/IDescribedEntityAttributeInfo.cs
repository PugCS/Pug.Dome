using System;

namespace Pug.Dome
{
	public interface IDescribedEntityAttributeInfo<out TKey, TValue/*, out TEntityVersionUser*/> : IEntityAttributeInfo<TKey, TValue/*, TEntityVersionUser*/>
	{
		string Description { get; }
	}
}