using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Effable
{
	//public interface IUpdatableEntityInfo<I, EVU> : IRegisteredEntityInfo<I, EVU>
	//{
	//}

	public interface IUpdateInfo< out TEntityVersionUser>
	{
		DateTime LastUpdateTimestamp
		{
			get;
		}

		TEntityVersionUser LastUpdateUser
		{
			get;
		}
	}
	//public interface IUpdatableEntityInfo<I> : IUpdatableEntityInfo<I, string>
	//{
	//}
}
