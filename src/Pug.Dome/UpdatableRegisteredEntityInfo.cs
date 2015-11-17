using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public abstract class UpdatableRegisteredEntityInfo<I, EVU> : RegisteredEntityInfo<I, EVU>, IUpdatableRegisteredEntityInfo<I, EVU>
	{
		protected UpdatableRegisteredEntityInfo(I identifier, DateTime registrationTimestamp, EVU registrationUser, DateTime lastUpdateTimestamp, EVU lastUpdateUser)
			: base(identifier, registrationTimestamp, registrationUser)
		{
			this.LastUpdateTimestamp = lastUpdateTimestamp;
			this.LastUpdateUser = lastUpdateUser;
		}

		public DateTime LastUpdateTimestamp { get; protected set; }

		public EVU LastUpdateUser { get; protected set; }
	}

}
