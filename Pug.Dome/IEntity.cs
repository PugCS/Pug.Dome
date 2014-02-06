using System;

namespace Pug.Dome
{

	public interface IEntity<INF, I> 
		where INF : IEntityInfo<I>
	{
		INF Info { get; }
	}
}
