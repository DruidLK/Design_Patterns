using Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Strategy.Abstractions.IExtensions;

namespace Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Strategy.DomainService.Extensions
{
    public sealed class Wheels : ICarExtension
    {
        public int Drive => 10;

        public int Attack => 7;

        public int Defend => 5;
    }
}
