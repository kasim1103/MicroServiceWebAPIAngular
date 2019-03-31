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
    public class LogService : ILogService
    {
        private readonly ILogRepository _logRepository;
        public LogService(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }

        bool status = false;
        public bool Delete(int? Id)
        {
            var idDel = Get(Id);
            if (idDel != null)
            {
                status = _logRepository.Delete(Id);
            }
            return status;
        }

        public List<Log> Get()
        {
            return _logRepository.Get();
        }

        public Log Get(int? Id)
        {
            var getLogId = _logRepository.Get(Id);
            if (Id == null)
            {
                Console.WriteLine("Insert Id");
                Console.Read();
            }
            return getLogId;
        }

        public bool Insert(LogParam logParam)
        {
            if (logParam == null)
            {
                Console.WriteLine("Insert Name");
                Console.Read();
            }
            else
            {
                _logRepository.Insert(logParam);
                status = true;
                Console.WriteLine("Success");
            }
            return status;
        }

        public bool Update(int? Id, LogParam logParam)
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
                _logRepository.Update(Id, logParam);
                status = true;
                Console.WriteLine("update Success");
            }
            return status;
        }
    }
}
