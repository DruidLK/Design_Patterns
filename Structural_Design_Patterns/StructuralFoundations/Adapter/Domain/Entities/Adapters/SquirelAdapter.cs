using Structural_Design_Patterns.StructuralFoundations.Adapter.Domain.Abstractions.IAdapters;
using Structural_Design_Patterns.StructuralFoundations.Adapter.Domain.Abstractions.IEntities;

namespace Structural_Design_Patterns.StructuralFoundations.Adapter.Domain.Entities.Adapters
{
    public sealed class SquirelAdapter : ICharacter
    {
        private readonly ISquirel squirel;

        public SquirelAdapter(ISquirel squirel) =>
            this.squirel = squirel;

        public int Chase =>
            this.squirel.Fly;

        public int Flee =>
            this.squirel.Fly;

        public int Attack =>
            this.squirel.DropACorn;
    }
}
