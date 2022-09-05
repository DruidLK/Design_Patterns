using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Base;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Enums;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Application.PizzaService.FactoryMethods.Base
{
    public abstract class PizzaStore
    {
        public Pizza Order(Types types) =>
            CreatePizza(types);

        protected abstract Pizza CreatePizza(Types types);
    }
}
