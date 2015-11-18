using System;

namespace Pug.Dome
{
    public interface IEntityAttributeInfo<out TKey, TValue, out TEntityVersionUser> : INamed<TKey>,  IRegisteredInfo<TEntityVersionUser>
    {
        TValue Value { get; }
    }

 //   public interface IEntityAttributeInfo : IEntityAttributeInfo<string, string, string>
	//{
	//}
}