using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Entities.PizzaTypes.Texas
{
    public sealed class TexasPepperoni : Pizza
    {
        public TexasPepperoni()
            : base("Pepperoni", "Texas")
        { }
    }
}
