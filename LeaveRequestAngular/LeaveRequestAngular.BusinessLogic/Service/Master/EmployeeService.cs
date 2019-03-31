using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using LeaveRequestWebAPI.Common.Repository;

namespace LeaveRequestWebAPI.BussinessLogic.Service.Master
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        bool status = false;
        public bool Delete(int? Id)
        {
            var idDel = Get(Id);
            if (idDel != null)
            {
                status = _employeeRepository.Delete(Id);
            }
            return status;
        }

        public List<Employee> Get()
        {
            return _employeeRepository.Get();
        }

        public Employee Get(int? Id)
        {
            var getEmployeeId = _employeeRepository.Get(Id);
            if (Id == null)
            {
                Console.WriteLine("Insert Id");
                Console.Read();
            }
            return getEmployeeId;
        }

        public bool Insert(EmployeeParam employeeParam)
        {
            if (employeeParam == null)
            {
                Console.WriteLine("Insert Name");
                Console.Read();
            }
            else
            {
                _employeeRepository.Insert(employeeParam);
                status = true;
                Console.WriteLine("Success");
            }
            return status;
        }

        public bool Update(int? Id, EmployeeParam employeeParam)
        {
            if (Id == null)
            {
                Console.WriteLine("Insert Id");
                Console.Read();
            }
            else if (Id == ' ')
            {
                Console.WriteLine("Dont Insert Blank Caracter");
                Console.Read();
            }
            else
            {
                _employeeRepository.Update(Id, employeeParam);
                status = true;
                Console.WriteLine("update Success");
            }
            return status;
        }

        public List<Employee> GetManager(int? Id)
        {
            return _employeeRepository.GetManager(Id);
        }
    }
}
