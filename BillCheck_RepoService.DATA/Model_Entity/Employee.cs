using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCheck_RepoService.DATA.Model_Entity
{
    public class Employee : BaseClass
    {
        public Employee()
        {
            // To avoid null reference exception
            OrdersOfEmployee = new List<Order>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal EmployeeSalary { get; set; }

        // 1 Employee - M Orders
        public List<Order> OrdersOfEmployee { get; set; }
    }
}
