using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public interface IRegisteredInfo<out TEntityVersionUser> : ICreatedInfo<TEntityVersionUser>
	{
		DateTime RegistrationTimestamp
		{
			get;
		}

		TEntityVersionUser RegistrationUser
		{
			get;
		}
	}
}
