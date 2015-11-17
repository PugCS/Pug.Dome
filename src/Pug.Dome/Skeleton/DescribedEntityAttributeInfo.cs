using System;

namespace Pug.Dome
{
	public class DescribedEntityAttributeInfo : EntityAttributeInfo, IDescribedEntityAttributeInfo
	{
		public DescribedEntityAttributeInfo(string name, string value, string description, DateTime specificationTimestamp, string specificationUser, DateTime lastModificationTimestamp, string lastModificationUser)
			: base(name, value, specificationTimestamp, specificationUser, lastModificationTimestamp, lastModificationUser)
		{
			this.Description = description;
		}

		public string Description { get; protected set; }
	}
}
