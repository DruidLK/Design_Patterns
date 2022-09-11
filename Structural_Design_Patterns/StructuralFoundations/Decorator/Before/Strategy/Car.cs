using Behavioral_Design_Pattern.StructuralFoundations.Decorator.Example_1.Before.Strategy.Abstractions.IExtensions;
using Behavioral_Design_Pattern.StructuralFoundations.Decorator.Example_1.Before.Strategy.DomainService;
using Behavioral_Design_Pattern.StructuralFoundations.Decorator.Example_1.Before.Strategy.DomainService.ExtensionsTypes;

namespace Behavioral_Design_Pattern.StructuralFoundations.Decorator.Example_1.Before.Strategy
{
    public sealed class Car
    {
        public int Drive { get; }
        public int Attack { get; }
        public int Defend { get; }


        public ICarExtension Extension(ExtensionsType carType) =>
            new HeavyArtillery().RetrieveCar(carType);
    }
}
