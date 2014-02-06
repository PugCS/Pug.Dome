using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public interface IRegisteredEntityInfo<I, EVU> : IEntityInfo<I>
	{
		DateTime RegistrationTimestamp
		{
			get;
		}

		EVU RegistrationUser
		{
			get;
		}
	}
}
