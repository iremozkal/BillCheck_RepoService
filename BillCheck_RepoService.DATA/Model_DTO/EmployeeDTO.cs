using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCheck_RepoService.DATA.Model_DTO
{
    public class EmployeeDTO
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal EmployeeSalary { get; set; }
        public int OrderCount { get; set; }			// the number of orders received by the employee
        public decimal TotalAmount { get; set; }	// the total money employee sold
    }
}
