using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.PizzaTypes.NewYorks
{
    public sealed class NewYorkPepperoni : Pizza
    {
        private const string type = "Pepperoni";
        private const string style = "NewYork";

        public NewYorkPepperoni()
            : base(style, type)
        { }
    }
}
