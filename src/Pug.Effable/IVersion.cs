namespace Pug.Effable
{
    public interface IVersion<TIdentifier, TObject>
    {
        IVersionInfo<TIdentifier> Info { get; }

        TObject Object { get; }
    }
}
