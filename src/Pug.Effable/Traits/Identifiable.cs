﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Effable
{
	public interface Identifiable<I>
	{
		I Identifier
		{
			get;
		}
	}
}
