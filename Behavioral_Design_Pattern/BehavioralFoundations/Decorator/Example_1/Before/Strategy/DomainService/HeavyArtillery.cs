using Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Strategy.Abstractions.IExtensions;
using Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Strategy.DomainService.Extensions;
using Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Strategy.DomainService.ExtensionsTypes;

namespace Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Strategy.DomainService
{
    public sealed class HeavyArtillery
    {
        public ICarExtension RetrieveCar(ExtensionsType car) =>
            car switch
            {
                ExtensionsType.Armor => new Armor(),
                ExtensionsType.Weopen => new Weopen(),
                ExtensionsType.Wheels => new Wheels(),
                ExtensionsType.ArmorWeopens => new ArmorWeopen(),
                _ => throw new ArgumentOutOfRangeException()
            };
    }
}
