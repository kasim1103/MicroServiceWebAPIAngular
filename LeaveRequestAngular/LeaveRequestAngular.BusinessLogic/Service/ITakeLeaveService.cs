using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.BussinessLogic.Service
{
    public interface ITakeLeaveService
    {
        bool Insert(TakeLeaveParam takeLeaveParam);
        bool Update(int? Id, TakeLeaveParam takeLeaveParam);
        bool Approve(int? Id, TakeLeaveParam takeLeaveParam);
        bool Delete(int? Id);
        List<TakeLeave> Get();
        TakeLeave Get(int? Id);
    }
}
