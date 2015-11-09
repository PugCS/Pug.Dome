using System;

namespace Pug.Dome
{
	public interface IEntityIdentifierAuthority
	{
		string GetIdentifier(string entityType);
	}
}
