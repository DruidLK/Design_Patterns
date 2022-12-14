using Structural_Design_Patterns.StructuralFoundations.Facade.Entities;
using Structural_Design_Patterns.StructuralFoundations.Facade.Entities.FoundationServices;

namespace Structural_Design_Patterns.Facade.Entities.ProcessServices
{
    public sealed class HR
    {
        private Finance finance;
        private OfficeAdministrator officeAdministrator;
        private SecurityAccess securityAccess;

        public HR()
        {
            this.finance = new Finance();
            this.officeAdministrator = new OfficeAdministrator();
            this.securityAccess = new SecurityAccess();
        }

        public void StartNewEmployeeProcess(Employee employee)
        {
            this.finance.AssignSalary(employee);
            this.officeAdministrator.GrantBuildingAccess(employee);
            this.securityAccess.GrantSecurityAccess(employee);

            Console.WriteLine($"{employee.Name} is ready to start!");
        }
    }
}
