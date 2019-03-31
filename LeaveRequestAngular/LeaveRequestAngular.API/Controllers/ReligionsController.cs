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
    public class ReligionsController : ApiController
    {
        private readonly IReligionRepository _religionRepository;
        public ReligionsController(IReligionRepository religionRepository)
        {
            _religionRepository = religionRepository;
        }
        // GET: api/Relegions
        public IEnumerable<Religion> Get()
        {
            return _religionRepository.Get();
        }

        // GET: api/Relegions/5
        public Religion Get(int Id)
        {
            return _religionRepository.Get(Id);
        }

        // POST: api/Relegions
        public void Post(ReligionParam religionParam)
        {
            _religionRepository.Insert(religionParam);
        }

        // PUT: api/Relegions/5
        public void Put(int Id, ReligionParam religionParam)
        {
            _religionRepository.Update(Id, religionParam);
        }

        // DELETE: api/Relegions/5
        public void Delete(int Id)
        {
            _religionRepository.Delete(Id);
        }
    }
}
