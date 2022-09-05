using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.Base;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.PizzaTypes.Chicagos;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Enums;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Services.Interfaces.IFactories;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Services.PizzaService.Factories
{
    public sealed class ChicagoFactory : IPizzaFactory
    {
        public Pizza Create(Types types) =>
            types switch
            {
                Types.Cheese => new ChicagoCheese(),
                Types.Pepperoni => new ChicagoPepperoni(),
                Types.Vegeterian => new ChicagoVegeterian(),
                _ => throw new ArgumentOutOfRangeException()
            };
    }
}
