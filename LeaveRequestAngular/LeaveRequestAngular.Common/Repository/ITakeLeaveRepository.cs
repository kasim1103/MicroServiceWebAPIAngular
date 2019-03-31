using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.Common.Repository
{
    public interface ITakeLeaveRepository
    {
        bool Insert(TakeLeaveParam takeLeaveParam);
        bool Update(int? Id, TakeLeaveParam takeLeaveParam);
        bool Approve(int? Id, TakeLeaveParam takeLeaveParam);
        bool Delete(int? Id);
        List<TakeLeave> Get();
        TakeLeave Get(int? Id);
    }
}
