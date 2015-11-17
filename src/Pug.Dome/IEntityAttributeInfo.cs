using System;

namespace Pug.Dome
{
    public interface IEntityAttributeInfo<out TEntityVersionUser>
    {
        string Name { get; }
        string Value { get; }

        DateTime SpecificationTimestamp
        {
            get;
        }

        TEntityVersionUser SpecificationUser
        {
            get;
        }

        DateTime LastModificationTimestamp { get; }
        TEntityVersionUser LastModificationUser { get; }
    }

    public interface IEntityAttributeInfo : IEntityAttributeInfo<string>
	{
	}
}