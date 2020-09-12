using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Effable
{
	public interface INamed<out N>
	{
		N Name
		{
			get;
		}
	}
}
