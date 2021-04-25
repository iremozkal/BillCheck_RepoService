using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillCheck_RepoService.DATA.Model_Entity;
using System.Data.Entity.ModelConfiguration;

namespace BillCheck_RepoService.DAL.Mapping
{
    public class OrderMapping : EntityTypeConfiguration<Order>
    {
        public OrderMapping()
        {
            HasKey(x => x.OrderId);

            // 1 Table has M Orders, 1 Order in 1 Table. (M-1)
            HasRequired(x => x.TableOfOrder).WithMany(x => x.OrdersOfTable).HasForeignKey(x => x.TableId);

            // 1 Order has M Products, 1 Product in M Orders. (M-M)
            HasMany(x => x.ProductsOfOrder).WithMany(x => x.OrdersOfProduct);
        }

    }
}
