using Behavioral_Design_Pattern.BehavioralFoundations.Template_Method.Domain.Base;

namespace Behavioral_Design_Pattern.BehavioralFoundations.Template_Method.Domain.Entities
{
    public sealed class NewYorkPizzaStore : PizzaStore
    {
        public override void CookPizza() =>
            Console.WriteLine(nameof(NewYorkPizzaStore) + "cooking");

        public override void MakePizza() =>
            Console.WriteLine(nameof(NewYorkPizzaStore) + "Making");

        public override void TakeOrder() =>
            Console.WriteLine(nameof(NewYorkPizzaStore) + "ordering");
    }
}
