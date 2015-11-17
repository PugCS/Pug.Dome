using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public interface IUpdatableEntity<tInfo, tIdentifier, tUpdateUser>
		: IEntity<tInfo, tIdentifier> 
			where tInfo : IEntityInfo<tIdentifier>, IUpdatableInfo<tUpdateUser>
	{
		void Refresh();
	}

	//public interface IUpdatableEntity<INF, EI> : IUpdatableEntity<INF, EI, string>
	//	where INF : IUpdatableEntityInfo<string>
	//{
	//}
}
