using Structural_Design_Patterns.StructuralFoundations.Adapter.Domain.Abstractions.IAdapters;
using Structural_Design_Patterns.StructuralFoundations.Adapter.Domain.Abstractions.IEntities;

namespace Structural_Design_Patterns.StructuralFoundations.Adapter.Domain.Entities.Adapters
{
    public sealed class MooseAdapter : ICharacter
    {
        private readonly IMoose moose;

        public MooseAdapter(IMoose moose) =>
            this.moose = moose;

        public int Chase =>
            this.moose.Run;

        public int Flee =>
            this.moose.Run;

        public int Attack =>
            this.moose.Charge;
    }
}
