using Structural_Design_Patterns.StructuralFoundations.Decorator.After.Domain.Abstractions.IExtensions;

namespace Structural_Design_Patterns.StructuralFoundations.Decorator.After.Domain.Extensions
{
    public sealed class AttackCar : ICar
    {
        private const int defaultAttack = 10;
        private readonly ICar car;

        public AttackCar(ICar car) =>
            this.car = car;

        public int Drive =>
            this.car.Drive;

        public int Attack =>
            this.car.Attack + defaultAttack;

        public int Armor =>
            this.car.Armor;
    }
}
