using System;
using System.Collections.Generic;
using System.Text;

namespace Pug.Effable
{
	public interface IRegistered<TEntityVersionUser, TRegistrationInfo> where TRegistrationInfo : IRegistrationInfo<TEntityVersionUser>
	{
		TRegistrationInfo RegistrationInfo { get; }
	}
}
