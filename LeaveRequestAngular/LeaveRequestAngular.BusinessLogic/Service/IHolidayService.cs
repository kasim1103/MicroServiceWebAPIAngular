using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.BussinessLogic.Service
{
    public interface IHolidayService
    {
        bool Insert(HolidayParam holidayParam);
        bool Update(int? Id, HolidayParam holidayParam);
        bool Delete(int? Id);
        List<Holiday> Get();
        Holiday Get(int? Id);
    }
}
