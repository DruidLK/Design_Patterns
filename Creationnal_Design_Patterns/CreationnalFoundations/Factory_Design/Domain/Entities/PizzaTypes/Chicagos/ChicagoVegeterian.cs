using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.PizzaTypes.Chicagos
{
    public sealed class ChicagoVegeterian : Pizza
    {
        private const string type = "Vegeterian";
        private const string style = "Chicago";

        public ChicagoVegeterian()
            : base(type, style)
        { }
    }
}
