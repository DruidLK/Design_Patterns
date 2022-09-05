namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Base
{
    public abstract class Pizza
    {
        public string Type { get; private set; }
        public string Style { get; private set; }
        public List<string> Ingredients { get; private set; }

        protected Pizza(string Type, string Style)
        { }
        public void AddIngredients(string ingredient) =>
            this.Ingredients.Add(ingredient);
    }
}
