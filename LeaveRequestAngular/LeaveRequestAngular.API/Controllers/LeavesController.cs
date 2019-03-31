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
    public class LeavesController : ApiController
    {
        private readonly ILeaveRepository _leaveRepository;
        public LeavesController(ILeaveRepository leaveRepository)
        {
            _leaveRepository = leaveRepository;
        }
        // GET: api/Leaves
        public IEnumerable<Leave> Get()
        {
            return _leaveRepository.Get();
        }

        // GET: api/Leaves/5
        public Leave Get(int Id)
        {
            return _leaveRepository.Get(Id);
        }

        public IEnumerable<Leave> GetType(string Type)
        {
            return _leaveRepository.GetType(Type);
        }

        // POST: api/Leaves
        public void Post(LeaveParam leaveParam)
        {
            _leaveRepository.Insert(leaveParam);
        }

        // PUT: api/Leaves/5
        public void Put(int Id, LeaveParam leaveParam)
        {
            _leaveRepository.Update(Id, leaveParam);
        }

        // DELETE: api/Leaves/5
        public void Delete(int Id)
        {
            _leaveRepository.Delete(Id);
        }
    }
}
