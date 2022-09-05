using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Entities.PizzaTypes.Texas
{
    public sealed class TexasVegeterian : Pizza
    {
        public TexasVegeterian()
            : base("Vegeterian", "Texas")
        { }
    }
}
