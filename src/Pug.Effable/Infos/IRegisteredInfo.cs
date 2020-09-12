using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Effable
{
	public interface IRegistrationInfo<out TEntityVersionUser>
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
