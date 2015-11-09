﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pug.Dome
{
	public interface INamedEntityInfo<tIdentifier, tName> : IEntityInfo<tIdentifier>, INamed<tName>
	{
	}

	//public interface INamedEntityInfo : INamedEntityInfo<string, string>
	//{
	//}
}
