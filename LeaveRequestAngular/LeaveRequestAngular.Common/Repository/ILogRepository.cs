using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.Common.Repository
{
    public interface ILogRepository
    {
        bool Insert(LogParam logParam);
        bool Update(int? Id, LogParam logParam);
        bool Delete(int? Id);
        List<Log> Get();
        Log Get(int? Id);
    }
}
