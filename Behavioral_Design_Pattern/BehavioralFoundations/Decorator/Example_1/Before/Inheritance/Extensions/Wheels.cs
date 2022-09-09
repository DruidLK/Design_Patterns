using Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Inheritance.Base;

namespace Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Inheritance.Extensions
{
    public sealed class Wheels : Car
    {
        public override int Drive => 15;
        public override int Attack => 2;
        public override int Defend => 3;
    }
}
