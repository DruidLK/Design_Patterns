namespace Behavioral_Design_Pattern.BehavioralFoundations.Facade.Entities.FoundationServices
{
    public sealed class OfficeAdministrator
    {
        public void GrantBuildingAccess(Employee employee) =>
            Console.WriteLine($"{employee.Name} has Access.");
    }
}
