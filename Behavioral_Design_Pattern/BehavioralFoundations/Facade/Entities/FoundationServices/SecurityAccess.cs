namespace Behavioral_Design_Pattern.BehavioralFoundations.Facade.Entities.FoundationServices
{
    public sealed class SecurityAccess
    {
        public void GrantSecurityAccess(Employee employee) =>
            Console.WriteLine($"{employee.Name} has security Access.");
    }
}
