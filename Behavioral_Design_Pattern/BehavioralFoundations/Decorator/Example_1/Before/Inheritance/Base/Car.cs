using Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Abstractions.IInheritance;

namespace Behavioral_Design_Pattern.BehavioralFoundations.Decorator.Example_1.Before.Inheritance.Base
{
    public abstract class Car : ICar
    {
        public virtual int Drive => 10;
        public virtual int Attack => 5;
        public virtual int Defend => 7;
    }
}
