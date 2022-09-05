namespace Behavioral_Design_Pattern.BehavioralFoundations.Facade.Entities.FoundationServices
{
    public sealed class Finance
    {
        public void AssignSalary(Employee employee) =>
            Console.WriteLine($"{employee.MonthlySalary} is 1000$");
    }
}
