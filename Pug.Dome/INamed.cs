using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public interface INamed<N>
	{
		N Name
		{
			get;
		}
	}
}
