namespace Structural_Design_Patterns.StructuralFoundations.Facade.Entities.FoundationServices
{
    public sealed class Finance
    {
        public void AssignSalary(Employee employee) =>
            Console.WriteLine($"{employee.MonthlySalary} is 1000$");
    }
}
