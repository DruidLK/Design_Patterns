using Structural_Design_Patterns.StructuralFoundations.Decorator.After.Domain.Abstractions.IExtensions;

namespace Structural_Design_Patterns.StructuralFoundations.Decorator.After.Domain.Extensions
{
    public sealed class RaceCar : ICar
    {
        private const int defaultSpeed = 10;
        private readonly ICar car;

        public RaceCar(ICar car) =>
            this.car = car;

        public int Drive =>
            this.car.Drive + defaultSpeed;

        public int Attack =>
            this.car.Attack;

        public int Armor =>
            this.car.Armor;
    }
}
