using BillCheck_RepoService.DATA.Model_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCheck_RepoService.BLL.UIService
{
    // Visible db models will use Dtos, because Service classes are the visible face of the project.

    public interface IEmployeeService
    {
        EmployeeDTO GetByEmployeeDtoId(int Id);
        List<EmployeeDTO> GetAllEmpDTO();
        bool Insert(EmployeeDTO ModelDto);
        bool Update(EmployeeDTO ModelDto);
        bool SoftDelete(EmployeeDTO ModelDto);
        bool HardDelete(int Id);
    }
}
