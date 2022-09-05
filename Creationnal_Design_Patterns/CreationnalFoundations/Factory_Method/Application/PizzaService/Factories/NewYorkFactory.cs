using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Application.Interfaces.IFactories;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Base;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Enums;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Entities.PizzaTypes.NewYorks;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Application.PizzaService.Factories
{
    public sealed class NewYorkFactory : IPizzaFactory
    {
        public Pizza Create(Types types) =>
            types switch
            {
                Types.Cheese => new NewYorkCheese(),
                Types.Pepperoni => new NewYorkPepperoni(),
                Types.Vegeterian => new NewYorkVegetarian(),
                _ => throw new ArgumentOutOfRangeException(paramName: "types is out of range.")
            };
    }
}
