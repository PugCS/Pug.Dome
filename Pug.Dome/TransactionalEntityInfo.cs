using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome.EntityFx
{
	public abstract class TransactionalEntityInfo<I, EVU> : RegisteredEntityInfo<I, EVU>, ITransactionalEntityInfo<I, EVU>
	{
		public TransactionalEntityInfo(I identifier, DateTime timestamp, DateTime registrationTimestamp, EVU registrationUser)
			: base(identifier, registrationTimestamp, registrationUser)
		{
			Timestamp = timestamp;
		}

		public DateTime Timestamp { get; protected set; }
	}

	public abstract class TransactionalEntityInfo : TransactionalEntityInfo<string, string>
	{
		public TransactionalEntityInfo(string identifier, DateTime registrationTimestamp, DateTime timestamp, string registrationUser)
			: base(identifier, registrationTimestamp, timestamp, registrationUser)
		{
		}
	}
}
