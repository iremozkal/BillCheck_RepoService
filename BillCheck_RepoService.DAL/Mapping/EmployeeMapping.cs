using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillCheck_RepoService.DATA.Model_Entity;
using System.Data.Entity.ModelConfiguration;

namespace BillCheck_RepoService.DAL.Mapping
{
    public class EmployeeMapping : EntityTypeConfiguration<Employee>
    {
        public EmployeeMapping()
        {
            HasKey(x => x.EmployeeId);
            Property(x => x.EmployeeId).HasColumnName("Id");
            Property(x => x.EmployeeName).HasMaxLength(100).IsRequired().HasColumnName("Name");
            Property(x => x.EmployeeSalary).IsRequired().HasColumnName("Salary");
            Property(x => x.DC).HasColumnName("Creation Date");
            Property(x => x.DM).HasColumnName("Change Date");
            Property(x => x.IA).HasColumnName("Activity Status");

            // 1 Employee has M Orders, 1 Order at 1 Employee. (M-1)
            HasMany(x => x.OrdersOfEmployee).WithRequired(x => x.EmployeeOfOrder).HasForeignKey(x => x.EmployeeId);
        }
    }
}
