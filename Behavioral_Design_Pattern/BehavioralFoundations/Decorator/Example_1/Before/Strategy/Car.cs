using Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Strategy.DomainService;

namespace Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Strategy
{
    public sealed class Car
    {
        public int Drive { get; }
        public int Attack { get; }
        public int Defend { get; }


        public string Extension(string carType) =>
            new HeavyArtillery().RetrieveCar(carType);
    }
}
