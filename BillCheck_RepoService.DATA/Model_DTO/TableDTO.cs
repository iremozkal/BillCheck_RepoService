using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCheck_RepoService.DATA.Model_DTO
{
    public class TableDTO
    {
        public int TableDtoID { get; set; }
        public string TableName { get; set; }
        public decimal TotalTableAmount { get; set; }   // the amount of money the table has made in total
    }
}
