using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.PizzaTypes.Chicagos
{
    public sealed class ChicagoCheese : Pizza
    {
        private const string type = "Cheese";
        private const string style = "Chicago";

        public ChicagoCheese()
            : base(type, style)
        { }
    }
}
