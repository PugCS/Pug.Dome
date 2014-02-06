using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public interface IEntityInfo<I> : Identifiable<I>
	{
	}

	public interface IEntityInfo : IEntityInfo<string>
	{
	}
}
