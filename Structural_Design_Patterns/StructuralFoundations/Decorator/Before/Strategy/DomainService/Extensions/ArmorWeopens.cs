using Behavioral_Design_Pattern.StructuralFoundations.Decorator.Example_1.Before.Strategy.Abstractions.IExtensions;

namespace Behavioral_Design_Pattern.StructuralFoundations.Decorator.Example_1.Before.Strategy.DomainService.Extensions
{
    public sealed class ArmorWeopen : ICarExtension
    {
        public int Drive => 12;
        public int Attack => 6;
        public int Defend => 7;
    }
}
