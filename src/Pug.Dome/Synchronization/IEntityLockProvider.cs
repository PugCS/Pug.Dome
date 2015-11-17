using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;

using Snowflake;

namespace Pug.Dome.Synchronization
{
	public interface IEntityLockProvider
	{
		string Lock(string identifier);

		string Lock(string identifier, int timeout);

		void Release(string identifier);
    }
}
