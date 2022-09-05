using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.Base;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Enums;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Services.Interfaces.IFactories;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Services.PizzaService.Factories;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Services.PizzaService.FactoryMethod.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Services.PizzaService.FactoryMethod
{
    public sealed class NewYork : PizzaStore
    {
        public NewYork()
            :this(new NewYorkFactory())
        { }

        public NewYork(IPizzaFactory pizzaFactory)
            : base(pizzaFactory)
        { }

        protected override Pizza Create(Types types) =>
            this.pizzaFactory.Create(types);
    }
}
