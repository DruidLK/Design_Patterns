using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.PizzaTypes.NewYorks
{
    public sealed class NewYorkCheese : Pizza
    {
        private const string type = "Cheese";
        private const string style = "NewYork";

        public NewYorkCheese()
            : base(type, style)
        { }
    }
}
