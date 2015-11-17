using System;

namespace Pug.Dome
{

	public interface IEntity<TInfo, TIdentifier, TEntityVersionUser> 
		where TInfo : IEntityInfo<TIdentifier, TEntityVersionUser>
	{
		TInfo Info { get; }
	}
}
