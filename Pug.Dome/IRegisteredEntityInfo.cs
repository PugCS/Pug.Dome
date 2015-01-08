using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public interface IRegisteredEntityInfo<tIdentifier, tRegistrationUser> : IEntityInfo<tIdentifier>, IRegisteredInfo<tRegistrationUser>
	{
	}
}
