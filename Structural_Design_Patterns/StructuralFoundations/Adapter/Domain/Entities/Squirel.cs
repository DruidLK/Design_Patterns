using Structural_Design_Patterns.StructuralFoundations.Adapter.Domain.Abstractions.IEntities;

namespace Structural_Design_Patterns.StructuralFoundations.Adapter.Domain.Entities
{
    public sealed class Squirel : ISquirel
    {
        private const int defaultNumbers = 20;
        public int Fly { get => defaultNumbers; }
        public int DropACorn { get => defaultNumbers; }
    }
}
