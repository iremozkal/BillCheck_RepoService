using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCheck_RepoService.DATA.Model_DTO
{
    public class ProductDTO
    {
        public int ProductDtoId { get; set; }
        public string ProductDtoName { get; set; }
        public decimal ProductDtoPrice { get; set; }
        public int TotalSellCount { get; set; }     // the total count sold from the product
    }
}
