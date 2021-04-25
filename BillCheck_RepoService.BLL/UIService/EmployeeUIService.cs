using BillCheck_RepoService.DAL.Repository;
using BillCheck_RepoService.DATA.Model_DTO;
using BillCheck_RepoService.DATA.Model_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCheck_RepoService.BLL.UIService
{
    // Bring entities by using repositories.
    // These entities must be converted to Dto and sent to the front.

    public class EmployeeUIService : IEmployeeService
    {
        // Create a repo object to use the methods in the repository.
        private readonly Repository<Employee> empRepo;

        public EmployeeUIService()
        {
            empRepo = new Repository<Employee>();
        }

        public EmployeeDTO GetByEmployeeDtoId(int Id)
        {
            Employee emp = empRepo.GetById(Id);
            EmployeeDTO newEmpDto = new EmployeeDTO()
            {
                EmployeeId = emp.EmployeeId,
                EmployeeName = emp.EmployeeName,
                EmployeeSalary = emp.EmployeeSalary,
                OrderCount = emp.OrdersOfEmployee.Count,
                TotalAmount = Convert.ToDecimal(emp.OrdersOfEmployee.Select(x => x.ProductsOfOrder.Sum(y => y.ProductPrice).ToString()))
            };

            return newEmpDto;
        }

        public List<EmployeeDTO> GetAllEmpDTO()
        {
            List<EmployeeDTO> empDtoList = new List<EmployeeDTO>();

            foreach (Employee item in empRepo.GetByAll())
            {
                EmployeeDTO newEmpDto = new EmployeeDTO()
                {
                    EmployeeId = item.EmployeeId,
                    EmployeeName = item.EmployeeName,
                    EmployeeSalary = item.EmployeeSalary,
                    OrderCount = item.OrdersOfEmployee.Count,
                    // TotalAmount = Convert.ToDecimal(item.OrdersOfEmployee.Select(x => x.ProductsOfOrder.Sum(y => y.ProductPrice).ToString()))
                };
                empDtoList.Add(newEmpDto);
            }

            return empDtoList;

            //return empRepo
            //    .GetByAll()
            //    .Where(x => x.EmployeeId == Id)
            //    .Select(x => new EmployeeDTO() 
            //    { EmployeeId = x.EmployeeId,
            //        EmployeeName = x.EmployeeName, 
            //        EmployeeSalary = x.EmployeeSalary, 
            //        OrderCount=x.OrdersOfEmployee.Count, 
            //        TotalAmount=Convert.ToDecimal(x.OrdersOfEmployee.Select(z=>z.ProductsOfOrder.Sum(f=>f.ProductPrice).ToString())) 
            //    })
            //        .FirstOrDefault() ;
        }

        public bool Insert(EmployeeDTO ModelDto)
        {
            Employee emp = new Employee()
            {
                EmployeeId = ModelDto.EmployeeId,
                EmployeeName = ModelDto.EmployeeName,
                EmployeeSalary = ModelDto.EmployeeSalary,
                DC = DateTime.Now,
                DM = DateTime.Now,
                IA = true
            };

            return empRepo.Insert(emp);
        }

        public bool Update(EmployeeDTO ModelDto)
        {
            Employee emp = empRepo.GetById(ModelDto.EmployeeId);
            emp.EmployeeName = ModelDto.EmployeeName;
            emp.EmployeeSalary = ModelDto.EmployeeSalary;

            return empRepo.Update(emp);
        }

        public bool SoftDelete(EmployeeDTO ModelDto)
        {
            Employee emp = empRepo.GetById(ModelDto.EmployeeId);
            emp.IA = false;
            emp.DM = DateTime.Now;

            return empRepo.SoftDelete(emp);
        }

        public bool HardDelete(int Id)
        {
            Employee emp = empRepo.GetById(Id);

            return empRepo.HardDelete(emp);
        }
    }
}
