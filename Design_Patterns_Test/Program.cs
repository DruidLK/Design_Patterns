
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Enums;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Services.PizzaService.Factories;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Services.PizzaService.FactoryMethod;

namespace Design_Patterns_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pizza = new Texas(new ChicagoFactory());
            var p = pizza.Order(Types.Cheese);
            System.Console.WriteLine(p);
        }
    }
}
