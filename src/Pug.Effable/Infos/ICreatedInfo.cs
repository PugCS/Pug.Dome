using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Effable
{
	public interface ICreationInfo<out TEntityVersionUser> : IRegistrationInfo<TEntityVersionUser>
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
