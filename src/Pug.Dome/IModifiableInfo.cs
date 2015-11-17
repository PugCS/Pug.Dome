using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public interface IModifiableInfo<out TEntityVersionUser> : IUpdatableInfo<TEntityVersionUser>
	{
		TEntityVersionUser LastModificationUser
		{
			get;
		}

		DateTime LastModificationTimestamp
		{
			get;
		}
	}
}
