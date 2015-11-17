using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public interface ICreatedInfo<out TEntityVersionUser>
	{
		TEntityVersionUser CreateUser
		{
			get;
		}

		DateTime CreateTimestamp
		{
			get;
		}
	}

}
