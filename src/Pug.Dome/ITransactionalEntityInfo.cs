using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public interface ITransactionalEntityInfo<tIdentifier, tRegistrationUser> 
		: IEntityInfo<tIdentifier>, IRegisteredInfo<tRegistrationUser>
	{
		DateTime Timestamp
		{
			get;
		}
	}

	//public interface ITransactionalEntityInfo : ITransactionalEntityInfo<string, string>
	//{

	//}
}
