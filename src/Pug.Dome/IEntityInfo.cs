using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public interface IEntityInfo<tIdentifier, tEntityVersionUser> : Identifiable<tIdentifier>, IRegisteredInfo<tEntityVersionUser>
	{
	}

	//public interface IEntityInfo : IEntityInfo<string>
	//{
	//}
}
