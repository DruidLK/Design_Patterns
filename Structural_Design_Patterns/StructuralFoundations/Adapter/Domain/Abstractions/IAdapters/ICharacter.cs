namespace Structural_Design_Patterns.StructuralFoundations.Adapter.Domain.Abstractions.IAdapters
{
    public interface ICharacter
    {
        int Chase { get; }
        int Flee { get; }
        int Attack { get; }
    }
}
