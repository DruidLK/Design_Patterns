using Structural_Design_Patterns.StructuralFoundations.Adapter.Domain.Abstractions.IAdapters;
using Structural_Design_Patterns.StructuralFoundations.Adapter.Domain.Abstractions.IEntities;

namespace Structural_Design_Patterns.StructuralFoundations.Adapter.Domain.Entities.Adapters
{
    public sealed class BadGuyAdapter : ICharacter
    {
        private readonly IBadGuy badGuy;

        public BadGuyAdapter(IBadGuy badGuy) =>
            this.badGuy = badGuy;

        public int Chase =>
            this.badGuy.Drive;

        public int Flee =>
            this.badGuy.Drive;

        public int Attack =>
            this.badGuy.Shoot;
    }
}
