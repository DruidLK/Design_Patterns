using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Application.Interfaces.IFactories;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Base;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Enums;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Entities.PizzaTypes.Texas;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Application.PizzaService.Factories
{
    public sealed class TexasFactory : IPizzaFactory
    {
        public Pizza Create(Types type) =>
            type switch
            {
                Types.Cheese => new TexasCheese(),
                Types.Pepperoni => new TexasPepperoni(),
                Types.Vegeterian => new TexasVegeterian(),
                _ => throw new ArgumentOutOfRangeException(paramName: "type out of range.")
            };
    }
}
