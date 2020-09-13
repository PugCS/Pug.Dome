using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Effable
{
	//public interface INamedEntityPublicInfo<TIdentifier, TName> : IEntityPublicInfo<TIdentifier>, INamed<TName>
	//{

	//}

	public interface INamedEntityInfo<TIdentifier, TName/*, TEntityVersionUser*/> : IEntityInfo<TIdentifier>, INamed<TName>
	{
        new TName Name
        {
            get;
            set;
        }
	}

	//public interface INamedEntityInfo : INamedEntityInfo<string, string>
	//{
	//}
}
