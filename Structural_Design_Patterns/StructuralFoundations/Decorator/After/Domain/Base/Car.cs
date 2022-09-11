using Structural_Design_Patterns.StructuralFoundations.Decorator.After.Domain.Abstractions.IExtensions;

namespace Structural_Design_Patterns.StructuralFoundations.Decorator.After.Domain.Base
{
    public sealed class Car : ICar
    {
        private const int DefaultNumbers = 100;
        public int Drive =>
            DefaultNumbers;

        public int Attack =>
            DefaultNumbers;

        public int Armor =>
            DefaultNumbers;
    }
}
