using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Effable
{
	public interface IAttributed<K, TAttributeInfo, V/*, TEntityVersionUser*/> where TAttributeInfo : IEntityAttributeInfo<K, V/*, TEntityVersionUser*/>
	{
		V this[K key]
		{
			get; 
		}

		IDictionary<K, TAttributeInfo> Attributes
		{
			get;
		}
	}
}
