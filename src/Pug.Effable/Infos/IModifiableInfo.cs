using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Effable
{
	public interface IModificationInfo<out TEntityVersionUser> : IUpdateInfo<TEntityVersionUser>
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
