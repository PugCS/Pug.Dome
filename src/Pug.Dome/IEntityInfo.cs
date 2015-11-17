using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public interface IEntityInfo<TIdentifier, out TEntityVersionUser> : Identifiable<TIdentifier>, IRegisteredInfo<TEntityVersionUser>
	{
	}

	//public interface IEntityInfo : IEntityInfo<string>
	//{
	//}
}
