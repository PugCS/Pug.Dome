using System;

namespace Pug.Effable
{
    public interface IEntityAttributeInfo<out TKey, TValue/*, out TEntityVersionUser*/> : INamed<TKey>//,  IRegisteredInfo<TEntityVersionUser>
    {
        TValue Value { get; set; }
    }

 //   public interface IEntityAttributeInfo : IEntityAttributeInfo<string, string, string>
	//{
	//}
}