using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.PizzaTypes.Texas
{
    public sealed class TexasCheese : Pizza
    {
        private const string type = "Cheese";
        private const string style = "Texas";

        public TexasCheese()
            : base(type, style)
        { }
    }
}
