using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using LeaveRequestWebAPI.DataAccess.Context;

namespace LeaveRequestWebAPI.Common.Repository.Master
{
    public class EmployeeRepository : IEmployeeRepository
    {
        MyContext myContext = new MyContext();
        Employee employee = new Employee();

        private bool status = false;
        public bool Delete(int? Id)
        {
            var result = 0;
            var getEmployeeId = Get(Id);
            getEmployeeId.IsDelete = true;
            getEmployeeId.DeleteDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }

            return status;
        }

        public List<Employee> Get()
        {
            var getDataEmployee = (from m in myContext.Employees join e in myContext.Employees on m.Managers.Id equals e.Id select m).ToList();
            return getDataEmployee;
        }

        public Employee Get(int? Id)
        {
            var getDataEmployee = myContext.Employees.Find(Id);
            return getDataEmployee;
        }

        public bool Insert(EmployeeParam employeeParam)
        {
            var result = 0;
            var getVillage = myContext.Villages.Find(employeeParam.Villages_Id);
            var getManager = myContext.Employees.Find(employeeParam.Managers_Id);
            var getDivision = myContext.Divisions.Find(employeeParam.Divisions_Id);
            var getPosition = myContext.Positions.Find(employeeParam.Positions_Id);
            var getReligion = myContext.Religions.Find(employeeParam.Religions_Id);

            employee.FirstName = employeeParam.FirstName;
            employee.LastName = employeeParam.LastName;
            employee.Gender = employeeParam.Gender;
            employee.Address = employeeParam.Address;
            employee.Marriage = employeeParam.Marriage;
            employee.ChildrenTotal = employeeParam.ChildrenTotal;
            employee.LastYear = employeeParam.LastYear;
            employee.ThisYear = employeeParam.ThisYear;
            employee.Username = employeeParam.Username;
            employee.Password = employeeParam.Password;
            employee.JoinDate = employeeParam.JoinDate;
            employee.CreateDate = DateTimeOffset.UtcNow.LocalDateTime;
            employee.Religions = getReligion;
            employee.Villages = getVillage;
            employee.Managers = getManager;
            employee.Divisions = getDivision;
            employee.Positions = getPosition;
            myContext.Employees.Add(employee);
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(int? Id, EmployeeParam employeeParam)
        {
            var result = 0;
            var getDataEmployee = Get(Id);
            var getVillage = myContext.Villages.Find(employeeParam.Villages_Id);
            var getManager = myContext.Employees.Find(employeeParam.Managers_Id);
            var getDivision = myContext.Divisions.Find(employeeParam.Divisions_Id);
            var getPosition = myContext.Positions.Find(employeeParam.Positions_Id);
            var getReligion = myContext.Religions.Find(employeeParam.Religions_Id);

            getDataEmployee.FirstName = employeeParam.FirstName;
            getDataEmployee.LastName = employeeParam.LastName;
            getDataEmployee.Gender = employeeParam.Gender;
            getDataEmployee.Address = employeeParam.Address;
            getDataEmployee.Marriage = employeeParam.Marriage;
            getDataEmployee.ChildrenTotal = employeeParam.ChildrenTotal;
            getDataEmployee.LastYear = employeeParam.LastYear;
            getDataEmployee.ThisYear = employeeParam.ThisYear;
            getDataEmployee.Username = employeeParam.Username;
            getDataEmployee.Password = employeeParam.Password;
            getDataEmployee.JoinDate = employeeParam.JoinDate;
            getDataEmployee.UpdateDate = DateTimeOffset.UtcNow.LocalDateTime;
            getDataEmployee.Religions = getReligion;
            getDataEmployee.Villages = getVillage;
            getDataEmployee.Managers = getManager;
            getDataEmployee.Divisions = getDivision;
            getDataEmployee.Positions = getPosition;

            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Employee> GetManager(int? Id)
        {
            var getListManager = myContext.Employees.Where(x => x.Managers.Id == Id).ToList();
            return getListManager;
        }
    }
}
