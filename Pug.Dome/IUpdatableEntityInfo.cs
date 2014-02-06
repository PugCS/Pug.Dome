using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public interface IUpdatableEntityInfo<I, EVU> : IRegisteredEntityInfo<I, EVU>
	{
		DateTime LastUpdateTimestamp
		{
			get;
		}

		EVU LastUpdateUser
		{
			get;
		}
	}
	//public interface IUpdatableEntityInfo<I> : IUpdatableEntityInfo<I, string>
	//{
	//}
}
