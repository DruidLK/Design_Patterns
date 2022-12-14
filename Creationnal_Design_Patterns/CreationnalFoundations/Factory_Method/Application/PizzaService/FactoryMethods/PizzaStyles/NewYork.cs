using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Application.Interfaces.IFactories;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Application.PizzaService.Factories;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Application.PizzaService.FactoryMethods.Base;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Base;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Enums;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Application.PizzaService.FactoryMethods.PizzaStyles
{
    public sealed class NewYork : PizzaStore
    {
        private readonly IPizzaFactory pizzaFactory;

        public NewYork()
            : this(new NewYorkFactory())
        { }

        private NewYork(IPizzaFactory pizzaFactory) =>
            this.pizzaFactory = pizzaFactory;

        protected override Pizza CreatePizza(Types types) =>
            this.pizzaFactory.Create(types);
    }
}
