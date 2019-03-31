using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.BussinessLogic.Service
{
    public interface ILogService
    {
        bool Insert(LogParam logParam);
        bool Update(int? Id, LogParam logParam);
        bool Delete(int? Id);
        List<Log> Get();
        Log Get(int? Id);
    }
}
