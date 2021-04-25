using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCheck_RepoService.DATA.Model_Entity
{
    public class Product : BaseClass
    {
        public Product()
        {
            // To avoid null reference exception
            OrdersOfProduct = new List<Order>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        // 1 Product - M Orders
        public List<Order> OrdersOfProduct { get; set; }
    }
}
