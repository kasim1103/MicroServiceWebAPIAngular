using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.BussinessLogic.Service
{
    public interface ILeaveService
    {
        bool Insert(LeaveParam leaveParam);
        bool Update(int? Id, LeaveParam leaveParam);
        bool Delete(int? Id);
        List<Leave> Get();
        Leave Get(int? Id);
        List<Leave> GetType(string Type);
    }
}
