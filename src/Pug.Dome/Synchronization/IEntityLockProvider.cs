namespace Pug.Dome.Synchronization
{
	public interface IEntityLockProvider
	{
		string Lock(string identifier);

		string Lock(string identifier, int timeout);

		void Release(string identifier);
    }
}
