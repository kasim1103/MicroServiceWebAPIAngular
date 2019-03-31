using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.Common.Repository
{
    public interface IHolidayRepository
    {
        bool Insert(HolidayParam holidayParam);
        bool Update(int? Id, HolidayParam holidayParam);
        bool Delete(int? Id);
        List<Holiday> Get();
        Holiday Get(int? Id);
    }
}
