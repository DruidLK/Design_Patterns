using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.Base;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.PizzaTypes.NewYorks;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Enums;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Services.Interfaces.IFactories;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Services.PizzaService.Factories
{
    public sealed class NewYorkFactory : IPizzaFactory
    {
        public Pizza Create(Types types) =>
            types switch
            {
                Types.Cheese => new NewYorkCheese(),
                Types.Pepperoni => new NewYorkPepperoni(),
                Types.Vegeterian => new NewYorkVegeterian(),
                _ => throw new ArgumentOutOfRangeException()
            };
    }
}
