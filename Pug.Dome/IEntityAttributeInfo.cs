using System;

namespace Pug.Dome
{
	public interface IEntityAttributeInfo
	{
		string Name { get; }
		string Value { get; }

		DateTime SpecificationTimestamp
		{
			get;
		}

		string SpecificationUser
		{
			get;
		}

		DateTime LastModificationTimestamp { get; }
		string LastModificationUser { get; }
	}
}