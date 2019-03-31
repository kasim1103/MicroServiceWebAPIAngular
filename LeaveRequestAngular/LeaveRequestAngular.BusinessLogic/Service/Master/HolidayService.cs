using LeaveRequestWebAPI.Common.Repository;
using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.BussinessLogic.Service.Master
{
    public class HolidayService : IHolidayService
    {
        private readonly IHolidayRepository _holidayRepository;
        public HolidayService(IHolidayRepository holidayRepository)
        {
            _holidayRepository = holidayRepository;
        }

        bool status = false;
        public bool Delete(int? Id)
        {
            var idDel = Get(Id);
            if (idDel != null)
            {
                status = _holidayRepository.Delete(Id);
            }
            return status;
        }

        public List<Holiday> Get()
        {
            return _holidayRepository.Get().ToList();
        }

        public Holiday Get(int? Id)
        {
            return _holidayRepository.Get(Id);
        }

        public bool Insert(HolidayParam holidayParam)
        {
            if (holidayParam != null)
            {
                status = _holidayRepository.Insert(holidayParam);
            }
            return status;
        }

        public bool Update(int? Id, HolidayParam holidayParam)
        {
            if (Id != null && holidayParam != null)
            {
                status = _holidayRepository.Update(Id, holidayParam);
            }
            return status;
        }
    }
}
