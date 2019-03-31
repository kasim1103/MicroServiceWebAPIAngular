using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.DataAccess.Param
{
    public class HolidayParam
    {
        public string Name { get; set; }
        public DateTimeOffset DateTime { get; set; }
    }
}
