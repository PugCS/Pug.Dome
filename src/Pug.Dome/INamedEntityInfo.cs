using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	//public interface INamedEntityPublicInfo<TIdentifier, TName> : IEntityPublicInfo<TIdentifier>, INamed<TName>
	//{

	//}

	public interface INamedEntityInfo<TIdentifier, TName/*, TEntityVersionUser*/> : IEntityInfo<TIdentifier>, INamed<TName>
	{
	}

	//public interface INamedEntityInfo : INamedEntityInfo<string, string>
	//{
	//}
}
