using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Entities.PizzaTypes.Chicagos
{
    public sealed class ChicagoVegeterian : Pizza
    {
        public ChicagoVegeterian()
            : base("Vegeterian", "Chicago")
        { }
    }
}
