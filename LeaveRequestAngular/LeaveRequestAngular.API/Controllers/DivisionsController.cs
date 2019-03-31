using LeaveRequestWebAPI.BussinessLogic.Service;
using LeaveRequestWebAPI.BussinessLogic.Service.Master;
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
    public class DivisionsController : ApiController
    {
        private readonly IDivisionService _divisionService;
        public DivisionsController (DivisionService divisionService)
        {
            _divisionService = divisionService;
        }
        // GET: api/Divisions
        public IEnumerable<Division> Get()
        {
            return _divisionService.Get();
        }

        // GET: api/Divisions/5
        public Division Get(int id)
        {
            return _divisionService.Get(id);
        }

        // POST: api/Divisions
        public void Post(DivisionParam divisionParam)
        {
            _divisionService.Insert(divisionParam);
        }

        // PUT: api/Divisions/5
        public void Put(int id, DivisionParam divisionParam)
        {
            _divisionService.Update(id, divisionParam);
        }

        // DELETE: api/Divisions/5
        public void Delete(int id)
        {
            _divisionService.Delete(id);
        }
    }
}
