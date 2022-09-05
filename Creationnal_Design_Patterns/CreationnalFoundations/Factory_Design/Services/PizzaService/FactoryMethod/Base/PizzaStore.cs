using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.Base;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Enums;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Services.Interfaces.IFactories;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Services.PizzaService.FactoryMethod.Base
{
    public abstract class PizzaStore
    {
        protected IPizzaFactory pizzaFactory;

        protected PizzaStore(IPizzaFactory pizzaFactory) =>
            this.pizzaFactory = pizzaFactory;

        public Pizza Order(Types types) =>
            Create(types);

        protected abstract Pizza Create(Types types);
    }
}
