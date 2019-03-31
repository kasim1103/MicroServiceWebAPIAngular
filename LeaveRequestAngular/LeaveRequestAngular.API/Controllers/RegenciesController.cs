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
    public class RegenciesController : ApiController
    {
        private readonly IRegencyService _regencyService;
        public RegenciesController (RegencyService regencyService)
        {
            _regencyService = regencyService;
        }
        // GET: api/Regencies
        public IEnumerable<Regency> Get()
        {
            return _regencyService.Get();
        }

        // GET: api/Regencies/5
        public Regency Get(int id)
        {
            return _regencyService.Get(id);
        }

        [HttpGet]
        public IEnumerable<Regency> GetRegency(int id)
        {
            return _regencyService.GetRegency(id);
        }

        // POST: api/Regencies
        public void Post(RegencyParam regencyParam)
        {
            _regencyService.Insert(regencyParam);
        }

        // PUT: api/Regencies/5
        public void Put(int id, RegencyParam regencyParam)
        {
            _regencyService.Update(id, regencyParam);
        }

        // DELETE: api/Regencies/5
        public void Delete(int id)
        {
            _regencyService.Delete(id);
        }
    }
}
