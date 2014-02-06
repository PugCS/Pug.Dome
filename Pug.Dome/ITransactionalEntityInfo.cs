using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public interface ITransactionalEntityInfo<I, EVU> : IRegisteredEntityInfo<I, EVU>
	{
		DateTime Timestamp
		{
			get;
		}
	}

	public interface ITransactionalEntityInfo : ITransactionalEntityInfo<string, string>
	{

	}
}
