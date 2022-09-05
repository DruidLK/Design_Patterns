using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Entities.PizzaTypes.Texas
{
    public sealed class TexasCheese : Pizza
    {
        public TexasCheese()
            : base("Cheese", "Texas")
        { }
    }
}
