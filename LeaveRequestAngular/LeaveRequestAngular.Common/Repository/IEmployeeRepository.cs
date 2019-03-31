using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.Common.Repository
{
    public interface IEmployeeRepository
    {
        bool Insert(EmployeeParam employeeParam);
        bool Update(int? Id, EmployeeParam employeeParam);
        bool Delete(int? Id);
        List<Employee> Get();
        List<Employee> GetManager(int? Id);
        Employee Get(int? Id);
    }
}
