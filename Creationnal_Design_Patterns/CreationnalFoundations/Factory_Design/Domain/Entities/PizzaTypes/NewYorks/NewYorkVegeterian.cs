using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.PizzaTypes.NewYorks
{
    public sealed class NewYorkVegeterian : Pizza
    {
        private const string type = "Vegeterian";
        private const string style = "NewYork";

        public NewYorkVegeterian()
            : base(type, style)
        { }
    }
}
