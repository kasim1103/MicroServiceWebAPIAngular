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
using System.Web.Http.Results;
using System.Web.Mvc;

namespace LeaveRequestWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProvincesController : ApiController
    {
        private readonly IProvinceService _provinceService;
        public ProvincesController(ProvinceService provinceService)
        {
            _provinceService = provinceService;
        }
        // GET: api/Provinces
        public JsonResult Get()
        {
            var getProvinces = _provinceService.Get();
            return new JsonResult()
            {
                Data = getProvinces,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        // GET: api/Provinces/5
        public Province Get(int id)
        {
            return _provinceService.Get(id);
        }

        // POST: api/Provinces
        public void Post(ProvinceParam provinceParam)
        {
            _provinceService.Insert(provinceParam);
        }

        // PUT: api/Provinces/5
        public void Put(int id, ProvinceParam provinceParam)
        {
            _provinceService.Update(id, provinceParam);
        }

        // DELETE: api/Provinces/5
        public void Delete(int id)
        {
            _provinceService.Delete(id);
        }
    }
}
