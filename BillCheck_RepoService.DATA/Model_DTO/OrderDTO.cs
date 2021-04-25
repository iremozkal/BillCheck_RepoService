using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCheck_RepoService.DATA.Model_DTO
{
    public class OrderDTO
    {
        public int OrderDtoId { get; set; }
        public int TableId { get; set; }
        public int EmployeeId { get; set; }
        public List<ProductDTO> ProductsOfOrderDTO { get; set; }
    }
}
