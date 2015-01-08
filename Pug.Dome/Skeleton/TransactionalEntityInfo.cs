using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome.EntityFx
{
	public abstract class TransactionalEntityInfo<I, EVU> : EntityInfo<I>, ITransactionalEntityInfo<I, EVU>
	{
		public TransactionalEntityInfo(I identifier, DateTime timestamp, DateTime registrationTimestamp, EVU registrationUser)
			: base(identifier)
		{
			Timestamp = timestamp;
			RegistrationTimestamp = registrationTimestamp;
			RegistrationUser = registrationUser;
		}

		public DateTime Timestamp { get; protected set; }

		public DateTime RegistrationTimestamp
		{
			get;
			protected set;
		}

		public EVU RegistrationUser
		{
			get;
			protected set;
		}
	}

	//public abstract class TransactionalEntityInfo : TransactionalEntityInfo<string, string>
	//{
	//	public TransactionalEntityInfo(string identifier, DateTime registrationTimestamp, DateTime timestamp, string registrationUser)
	//		: base(identifier, registrationTimestamp, timestamp, registrationUser)
	//	{
	//	}
	//}
}
