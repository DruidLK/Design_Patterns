using System;
using Structural_Design_Patterns.StructuralFoundations.Proxy.Domain;
using Structural_Design_Patterns.StructuralFoundations.Proxy.Domain.Ships.ShipsTypes;

namespace Design_Patterns_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ship = new Ship(Name: "fadi");

            ship.ShipName(ShipsType.UFO);

            Console.WriteLine(ship.Name);
        }
    }
}
