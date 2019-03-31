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
    public class PositionsController : ApiController
    {
        private readonly IPositionService _positionService;
        public PositionsController (PositionService positionService)
        {
            _positionService = positionService;
        }
        // GET: api/Positions
        public IEnumerable<Position> Get()
        {
            return _positionService.Get();
        }

        // GET: api/Positions/5
        public Position Get(int id)
        {
            return _positionService.Get(id);
        }

        // POST: api/Positions
        public void Post(PositionParam positionParam)
        {
            _positionService.Insert(positionParam);
        }

        // PUT: api/Positions/5
        public void Put(int id, PositionParam positionParam)
        {
            _positionService.Update(id, positionParam);
        }

        // DELETE: api/Positions/5
        public void Delete(int id)
        {
            _positionService.Delete(id);
        }
    }
}
