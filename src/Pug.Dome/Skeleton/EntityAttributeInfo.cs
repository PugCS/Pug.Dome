using System;

namespace Pug.Dome
{
	public class EntityAttributeInfo<TKey, TValue/*, TEntityVersionUser*/> : IEntityAttributeInfo<TKey, TValue/*, TEntityVersionUser*/>
	{
		TKey name;
		TValue value;
		readonly bool isPublic;
		//TEntityVersionUser registrationUser, createUser;
		//readonly DateTime registrationTimestamp, createTimestamp;

		public EntityAttributeInfo(TKey name, TValue value, bool isPublic/*, DateTime specificationTimestamp, TEntityVersionUser specificationUser, DateTime createTimestamp, TEntityVersionUser createUser*/)
		{
			this.name = name;
			this.value = value;
			this.isPublic = isPublic;
			//this.registrationTimestamp = specificationTimestamp;
			//this.registrationUser = specificationUser;
			//this.createTimestamp = createTimestamp;
			//this.createUser = createUser;
		}

		public TKey Name
		{
			get { return name; }
		}

		public TValue Value
		{
			get { return value; }
		}

		public bool IsPublic
		{
			get 
			{
				return this.isPublic;
			}
		}

		//public DateTime RegistrationTimestamp
		//{
		//	get
		//	{
		//		return registrationTimestamp;
		//	}
		//}

		//public TEntityVersionUser RegistrationUser
		//{
		//	get
		//	{
		//		return registrationUser;
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
		//	}
		//}

		//public DateTime LastModificationTimestamp
		//{
		//	get
		//	{
		//		return lastModificationTimestamp;
		//	}
		//}

		//public string LastModificationUser
		//{
		//	get
		//	{
		//		return lastModificationUser;
		//	}
		//}
	}
}
