namespace Behavioral_Design_Pattern.BehavioralFoundations.Observer.Entities
{
    public sealed class Candidates
    {
        public string Name { get; set; }

        public void Notify(string opportunity) =>
            Console.WriteLine($"{this.Name} has been notified about the new {opportunity}.");
    }
}
