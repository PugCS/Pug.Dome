using System;

namespace Pug.Dome
{
	public interface IEntityAttribute
	{
		DateTime LastModificationTimestamp { get; }
		string LastModificationUser { get; }
		string Name { get; }
		string Value { get; }
	}
}
