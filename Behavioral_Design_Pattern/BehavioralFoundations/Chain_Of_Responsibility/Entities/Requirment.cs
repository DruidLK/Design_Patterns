namespace Behavioral_Design_Pattern.BehavioralFoundations.ChainOfResponsibility.Entities
{
    public sealed class Requirment
    {
        public List<string> OperationsDone { get; set; }

        public Requirment() =>
            this.OperationsDone = new List<string>();
    }
}
