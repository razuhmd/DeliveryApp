using DeliveryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Catalogs
{
    public class AdministratorCatalog
    {
        private Dictionary<int, Administrator> administrators { get; } = new Dictionary<int, Administrator>();

        public AdministratorCatalog()
        {
            administrators.Add(1, new Administrator() { EmployeeId = 1, AdministratorLoginId = 1, AdministratorPassword = "asd" });
        }

        public Dictionary<int, Administrator> AllAdministrators()
        {
            return administrators;
        }

        public void AddAdministrator(Administrator administrator)
        {
            administrators.Add(administrator.EmployeeId, administrator);
        }

        public void RemoveAdministrator(Administrator administrator)
        {
            administrators.Remove(administrator.EmployeeId);
        }

       
        
    }
}
