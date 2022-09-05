using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.PizzaTypes.Texas
{
    public sealed class TexasVegeterian : Pizza
    {
        private const string type = "Vegeterian";
        private const string style = "Texas";

        public TexasVegeterian()
            : base(type, style)
        { }
    }
}
