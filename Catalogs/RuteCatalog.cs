using DeliveryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Catalogs
{
    public class RuteCatalog
    {
        private Dictionary<int, Rute> rutes { get; }

        private Employee employee = new Employee() { EmployeeId = 1, EmployeeName = "Peter", EmployeeEmail = "peter@yaho.com", EmployeeAddress = "Sagstuvagen 1, 0000 København", EmployeePhoneNumber = "22334455", EmployeeType = "Administrator" };

        public RuteCatalog()
        {
            rutes = new Dictionary<int, Rute>();
            rutes.Add(1, new Rute() { RuteId = 53, Employee = employee});
            rutes.Add(2, new Rute() { RuteId = 54 });
        }

        public Dictionary<int, Rute> AllRutes()
        {
            return rutes;
        }

        public void AddRute(Rute rute)
        {
            rutes.Add(rute.RuteId, rute);
        }

        public void RemoveRute(Rute rute)
        {
            rutes.Remove(rute.RuteId);
        }

        public bool UpdateRute(int ruteId, Rute rute)
        {
            foreach (var ruteItem in rutes)
            {
                if (ruteItem.Value.RuteId == ruteId)
                {
                    ruteItem.Value.RuteId = rute.RuteId;
                    ruteItem.Value.Employee = rute.Employee;

                    return true;
                }                
            }
            return false;
        }

    }
}
