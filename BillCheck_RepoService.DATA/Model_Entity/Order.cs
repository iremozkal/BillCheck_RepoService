using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCheck_RepoService.DATA.Model_Entity
{
    public class Order : BaseClass
    {
        public Order()
        {
            // To avoid null reference exception
            TableOfOrder = new Table();
            ProductsOfOrder = new List<Product>();
            EmployeeOfOrder = new Employee();
        }

        public int OrderId { get; set; }

        // 1 Order - 1 Table
        public int TableId { get; set; }
        public Table TableOfOrder { get; set; }

        // 1 Order - M Products
        public List<Product> ProductsOfOrder { get; set; }

        // 1 Order - 1 Employee
        public int EmployeeId { get; set; }
        public Employee EmployeeOfOrder { get; set; }
    }
}
