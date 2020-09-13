namespace Pug.Effable
{
	public interface IModifiable<out TEntityVersionUser, out TModificationInfo> where TModificationInfo : IModificationInfo<TEntityVersionUser>
	{
		TModificationInfo LastModificationInfo { get; }
	}
}
