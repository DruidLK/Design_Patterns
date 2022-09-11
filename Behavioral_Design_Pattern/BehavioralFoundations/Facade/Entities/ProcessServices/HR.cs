using Behavioral_Design_Pattern.BehavioralFoundations.Facade.Entities;
using Behavioral_Design_Pattern.BehavioralFoundations.Facade.Entities.FoundationServices;

namespace Behavioral_Design_Pattern.Facade.Entities.ProcessServices
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
