using Structural_Design_Patterns.StructuralFoundations.Adapter.Domain.Abstractions.IEntities;

namespace Structural_Design_Patterns.StructuralFoundations.Adapter.Domain.Entities
{
    public sealed class BadGuy : IBadGuy
    {
        private const int defaultNumbers = 30;
        public int Drive { get => defaultNumbers; }
        public int Shoot { get => defaultNumbers; }
    }
}
