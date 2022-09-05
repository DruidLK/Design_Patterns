using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Entities.PizzaTypes.NewYorks
{
    public sealed class NewYorkPepperoni : Pizza
    {
        public NewYorkPepperoni()
            : base("Pepperoni", "NewYork")
        { }
    }
}
