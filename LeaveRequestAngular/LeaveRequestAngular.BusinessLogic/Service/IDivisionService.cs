using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.BussinessLogic.Service
{
    public interface IDivisionService
    {
        bool Insert(DivisionParam divisionParam);
        bool Update(int? Id, DivisionParam divisionParam);
        bool Delete(int? Id);
        List<Division> Get();
        Division Get(int? Id);
    }
}
