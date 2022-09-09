using Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Inheritance.Base;

namespace Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Inheritance.Extensions
{
    public sealed class Weopen : Car
    {
        public override int Drive => 8;
        public override int Attack => 15;
        public override int Defend => 5;
    }
}
