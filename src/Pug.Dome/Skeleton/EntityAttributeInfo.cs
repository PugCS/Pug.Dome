using System;

namespace Pug.Dome
{
	public class EntityAttributeInfo : IEntityAttributeInfo
	{
		string name, value, specificationUser, lastModificationUser;
		DateTime specificationTimestamp, lastModificationTimestamp;

		public EntityAttributeInfo(string name, string value, DateTime specificationTimestamp, string specificationUser, DateTime lastModificationTimestamp, string lastModificationUser)
		{
			this.name = name;
			this.value = value;
			this.specificationTimestamp = specificationTimestamp;
			this.specificationUser = specificationUser;
			this.lastModificationTimestamp = lastModificationTimestamp;
			this.lastModificationUser = lastModificationUser;
		}

		public string Name
		{
			get { return name; }
		}

		public string Value
		{
			get { return value; }
		}

		public DateTime SpecificationTimestamp
		{
			get
			{
				return specificationTimestamp;
			}
		}

		public string SpecificationUser
		{
			get
			{
				return specificationUser;
			}
		}

		public DateTime LastModificationTimestamp
		{
			get
			{
				return lastModificationTimestamp;
			}
		}

		public string LastModificationUser
		{
			get
			{
				return lastModificationUser;
			}
		}
	}
}
