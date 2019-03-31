using LeaveRequestWebAPI.Common.Repository;
using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LeaveRequestWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // GET: api/Employees
        public IEnumerable<Employee> Get()
        {
            return _employeeRepository.Get();
        }
    
        public IEnumerable<Employee> GetManager(int Id)
        {
            return _employeeRepository.GetManager(Id);
        }

        // GET: api/Employees/5
        public Employee Get(int Id)
        {
            return _employeeRepository.Get(Id);
        }

        // POST: api/Employees
        public void Post(EmployeeParam employeeParam)
        {
            _employeeRepository.Insert(employeeParam);
        }

        // PUT: api/Employees/5
        public void Put(int Id, EmployeeParam employeeParam)
        {
            _employeeRepository.Update(Id, employeeParam);
        }

        // DELETE: api/Employees/5
        public void Delete(int Id)
        {
            _employeeRepository.Delete(Id);
        }
    }
}
