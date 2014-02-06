using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public interface IUpdatableEntity<INF, I, EVU> : IEntity<INF, I> 
		where INF : IUpdatableEntityInfo<I, EVU>
	{
		void Refresh();
	}

	//public interface IUpdatableEntity<INF, EI> : IUpdatableEntity<INF, EI, string>
	//	where INF : IUpdatableEntityInfo<string>
	//{
	//}
}
