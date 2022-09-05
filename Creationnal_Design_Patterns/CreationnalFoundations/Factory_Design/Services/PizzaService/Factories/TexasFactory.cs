using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.Base;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.PizzaTypes.Texas;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Enums;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Services.Interfaces.IFactories;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Services.PizzaService.Factories
{
    public sealed class TexasFactory : IPizzaFactory
    {
        public Pizza Create(Types types) =>
            types switch
            {
                Types.Cheese => new TexasCheese(),
                Types.Pepperoni => new TexasPepperoni(),
                Types.Vegeterian => new TexasVegeterian(),
                _ => throw new ArgumentOutOfRangeException()
            };
    }
}
