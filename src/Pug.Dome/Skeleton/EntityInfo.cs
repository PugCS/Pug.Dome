using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public abstract class EntityInfo<TIdentifier/*, TEntityVersionUser*/> : IEntityInfo<TIdentifier/*, TEntityVersionUser*/>
	{
		TIdentifier identifier;
		//TEntityVersionUser createUser;
		//readonly DateTime createTimestamp;
		//TEntityVersionUser registrationUser;
		//readonly DateTime registrationTimestamp;

		protected EntityInfo(TIdentifier identifier/*, TEntityVersionUser registrationUser, DateTime registrationTimestamp, TEntityVersionUser createUser, DateTime createTimestamp */)
		{
			this.identifier = identifier;
			//this.createUser = createUser;
			//this.createTimestamp = createTimestamp;
			//this.registrationUser = registrationUser;
			//this.registrationTimestamp = registrationTimestamp;
		}

		public TIdentifier Identifier
		{ 
			get { return this.identifier; }
			protected set { this.identifier = value; }
		}

		//public DateTime RegistrationTimestamp
		//{
		//	get
		//	{
		//		return this.registrationTimestamp;
		//	}
		//}

		//public TEntityVersionUser RegistrationUser
		//{
		//	get
		//	{
		//		return this.registrationUser;
		//	}
		//}

		//public TEntityVersionUser CreateUser
		//{
		//	get
		//	{
		//		return createUser;
		//	}
		//}

		//public DateTime CreateTimestamp
		//{
		//	get
		//	{
		//		return createTimestamp;
  //          }
		//}
	}
}
