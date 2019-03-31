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
    public class HolidaysController : ApiController
    {
        private readonly IHolidayService _holidayService;
        public HolidaysController(HolidayService holidayService)
        {
            _holidayService = holidayService;
        }
        // GET: api/Holidays
        public IEnumerable<Holiday> Get()
        {
            return _holidayService.Get();
        }

        // GET: api/Holidays/5
        public Holiday Get(int id)
        {
            return _holidayService.Get(id);
        }

        // POST: api/Holidays
        public void Post(HolidayParam holidayParam)
        {
            _holidayService.Insert(holidayParam);
        }

        // PUT: api/Holidays/5
        public void Put(int id, HolidayParam holidayParam)
        {
            _holidayService.Update(id, holidayParam);
        }

        // DELETE: api/Holidays/5
        public void Delete(int id)
        {
            _holidayService.Delete(id);
        }
    }
}
