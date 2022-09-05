using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.PizzaTypes.Texas
{
    public sealed class TexasPepperoni : Pizza
    {
        private const string type = "Pepperoni";
        private const string style = "Texas";

        public TexasPepperoni()
            : base(type, style)
        { }
    }
}
