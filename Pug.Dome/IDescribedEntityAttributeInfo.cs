using System;

namespace Pug.Dome
{
	public interface IDescribedEntityAttributeInfo : IEntityAttributeInfo
	{
		string Description { get; }
	}
}