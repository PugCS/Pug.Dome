using System;

namespace Pug.Dome
{
	public interface IEntity<TInfo, TIdentifier> 
		where TInfo : IEntityInfo<TIdentifier>
	{
		TInfo Info { get; }
	}
}
