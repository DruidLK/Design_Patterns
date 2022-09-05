using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.PizzaTypes.Chicagos
{
    public sealed class ChicagoPepperoni : Pizza
    {
        private const string type = "Pepperoni";
        private const string style = "Chicago";

        public ChicagoPepperoni()
            : base(type, style)
        { }
    }
}
