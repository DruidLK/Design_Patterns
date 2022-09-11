namespace Behavioral_Design_Pattern.BehavioralFoundations.Template_Method.Domain.Base
{
    public abstract class PizzaStore
    {
        public void CreatePizzaForDelivery()
        {
            TakeOrder();
            ProcessPayment();
            MakePizza();
            CookPizza();
            DeliverPizza();
        }

        public abstract void TakeOrder();
        public abstract void MakePizza();
        public abstract void CookPizza();

        public virtual void ProcessPayment() =>
            Console.WriteLine("Payment is being processed.");

        public virtual void DeliverPizza() =>
            Console.WriteLine("delivering of Pizza.");
    }
}
