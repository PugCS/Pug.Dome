namespace Pug.Effable
{
    public interface IVersionInfo<IdentifierType> : Identifiable<IdentifierType>
    {
        string UserType { get; }

        string User { get; }
    }
}
