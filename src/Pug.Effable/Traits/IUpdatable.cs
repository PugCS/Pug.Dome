namespace Pug.Effable
{
	public interface IUpdatable<out TEntityVersionUser, out TUpdateInfo> where TUpdateInfo : IUpdateInfo<TEntityVersionUser>
	{
		TUpdateInfo LastUpdateInfo { get; }
	}
}
