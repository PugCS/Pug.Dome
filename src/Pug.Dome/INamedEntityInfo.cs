using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public interface INamedEntityInfo<TIdentifier, TName, TEntityVersionUser> : IEntityInfo<TIdentifier, TEntityVersionUser>, INamed<TName>
	{
	}

	//public interface INamedEntityInfo : INamedEntityInfo<string, string>
	//{
	//}
}
