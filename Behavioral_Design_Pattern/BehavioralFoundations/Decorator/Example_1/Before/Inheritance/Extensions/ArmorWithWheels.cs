using Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Inheritance.Base;

namespace Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Inheritance.Extensions
{
    public sealed class ArmorWithWheels : Car
    {
        public override int Drive => 14;
        public override int Attack => 2;
        public override int Defend => 10;
    }
}
