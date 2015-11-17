using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public interface IUpdatableEntity<TInfo, TIdentifier, TEntityVersionUser>
		: IEntity<TInfo, TIdentifier, TEntityVersionUser> 
			where TInfo : IEntityInfo<TIdentifier, TEntityVersionUser>, IUpdatableInfo<TEntityVersionUser>
	{
		void Refresh();
	}

	//public interface IUpdatableEntity<INF, EI> : IUpdatableEntity<INF, EI, string>
	//	where INF : IUpdatableEntityInfo<string>
	//{
	//}
}
