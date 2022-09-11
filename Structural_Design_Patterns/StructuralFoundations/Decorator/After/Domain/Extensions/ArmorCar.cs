using Structural_Design_Patterns.StructuralFoundations.Decorator.After.Domain.Abstractions.IExtensions;

namespace Structural_Design_Patterns.StructuralFoundations.Decorator.After.Domain.Extensions
{
    public sealed class ArmorCar : ICar
    {
        private const int defaultArmor = 10;
        private readonly ICar car;

        public ArmorCar(ICar car) =>
            this.car = car;

        public int Drive =>
            this.car.Drive;

        public int Attack =>
            this.car.Attack;

        public int Armor =>
            this.car.Armor + defaultArmor;

    }
}
