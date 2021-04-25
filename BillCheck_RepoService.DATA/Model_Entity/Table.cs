using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCheck_RepoService.DATA.Model_Entity
{
    public class Table : BaseClass
    {
        public Table()
        {
            // To avoid null reference exception
            OrdersOfTable = new List<Order>();
        }

        public int TableId { get; set; }
        public string TableName { get; set; }

        // 1 Table - M Orders
        public List<Order> OrdersOfTable { get; set; }
    }
}
