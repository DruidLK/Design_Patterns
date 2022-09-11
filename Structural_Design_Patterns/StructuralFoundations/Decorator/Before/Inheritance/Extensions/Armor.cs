using Behavioral_Design_Pattern.StructuralFoundations.Decorator.Example_1.Before.Inheritance.Base;

namespace Behavioral_Design_Pattern.StructuralFoundations.Decorator.Example_1.Before.Inheritance.Extensions
{
    public sealed class Armor : Car
    {
        public override int Drive => 5;
        public override int Attack => 5;
        public override int Defend => 17;
    }
}
