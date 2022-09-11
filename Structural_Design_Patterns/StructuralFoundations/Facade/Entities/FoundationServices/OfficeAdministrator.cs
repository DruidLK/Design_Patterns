namespace Structural_Design_Patterns.StructuralFoundations.Facade.Entities.FoundationServices
{
    public sealed class OfficeAdministrator
    {
        public void GrantBuildingAccess(Employee employee) =>
            Console.WriteLine($"{employee.Name} has Access.");
    }
}
