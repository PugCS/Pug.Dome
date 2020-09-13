using System;

namespace Pug.Effable
{
    public interface IEntity<TInfo, TIdentifier> 
		where TInfo : IEntityInfo<TIdentifier>
	{
		TIdentifier Identifier { get; }

		TInfo GetInfo();
    }
}
