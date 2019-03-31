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
    public class LogRepository : ILogRepository
    {
        MyContext myContext = new MyContext();
        Log log = new Log();

        private bool status = false;
        public bool Delete(int? Id)
        {
            var result = 0;
            var getLogId = Get(Id);
            getLogId.IsDelete = true;
            getLogId.DeleteDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }

            return status;
        }

        public List<Log> Get()
        {
            var getDataLog = myContext.Logs.Where(x => x.IsDelete == false).ToList();
            return getDataLog;
        }

        public Log Get(int? Id)
        {
            var getDataLog = myContext.Logs.Find(Id);
            return getDataLog;
        }

        public bool Insert(LogParam logParam)
        {
            var result = 0;
            log.LogDate = logParam.LogDate;
            log.CreateDate = DateTimeOffset.UtcNow.LocalDateTime;
            myContext.Logs.Add(log);
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(int? Id, LogParam logParam)
        {
            var result = 0;
            var getDataLog = Get(Id);
            getDataLog.LogDate = logParam.LogDate;
            getDataLog.UpdateDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
