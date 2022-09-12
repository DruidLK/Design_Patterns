using Structural_Design_Patterns.StructuralFoundations.Adapter.Domain.Abstractions.IEntities;

namespace Structural_Design_Patterns.StructuralFoundations.Adapter.Domain.Entities
{
    public sealed class Moose : IMoose
    {
        private const int defaultNumbers = 5;
        public int Run { get => defaultNumbers; }
        public int Charge { get => defaultNumbers; }
    }
}
