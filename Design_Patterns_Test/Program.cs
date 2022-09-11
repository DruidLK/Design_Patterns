using System;
using Behavioral_Design_Pattern.StructuralFoundations.Decorator.Example_1.Before.Strategy.DomainService.Extensions;
using Structural_Design_Patterns.StructuralFoundations.Decorator.After.Domain.Base;
using Structural_Design_Patterns.StructuralFoundations.Decorator.After.Domain.Extensions;

namespace Design_Patterns_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var car_1 = new RaceCar(new ArmorCar(new Car()));

            Console.WriteLine(car_1.Drive);
            Console.WriteLine(car_1.Attack);
            Console.WriteLine(car_1.Armor);
        }
    }
}
