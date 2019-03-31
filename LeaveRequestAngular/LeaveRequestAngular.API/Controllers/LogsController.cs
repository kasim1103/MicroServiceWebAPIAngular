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
    public class LogsController : ApiController
    {
        private readonly ILogRepository _logRepository;
        public LogsController(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }
        // GET: api/Logs
        public IEnumerable<Log> Get()
        {
            return _logRepository.Get();
        }

        // GET: api/Logs/5
        public Log Get(int Id)
        {
            return _logRepository.Get(Id);
        }

        // POST: api/Logs
        public void Post(LogParam logParam)
        {
            _logRepository.Insert(logParam);
        }

        // PUT: api/Logs/5
        public void Put(int Id, LogParam logParam)
        {
            _logRepository.Update(Id, logParam);
        }

        // DELETE: api/Logs/5
        public void Delete(int Id)
        {
            _logRepository.Delete(Id);
        }
    }
}
