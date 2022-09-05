using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Application.Interfaces.IFactories;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Base;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Enums;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Entities.PizzaTypes.Chicagos;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Application.PizzaService.Factories
{
    public sealed class ChicagoFactory : IPizzaFactory
    {
        public Pizza Create(Types types) =>
            types switch
            {
                Types.Cheese => new ChicagoCheese(),
                Types.Pepperoni => new ChicagoPepperoni(),
                Types.Vegeterian => new ChicagoVegeterian(),
                _ => throw new ArgumentOutOfRangeException(paramName: "Types is out of range.")
            };
    }
}
