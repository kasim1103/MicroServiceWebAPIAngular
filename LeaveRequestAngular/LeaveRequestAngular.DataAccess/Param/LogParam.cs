using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.DataAccess.Param
{
    public class LogParam
    {
        public DateTimeOffset LogDate { get; set; }
        public int Employee_Id { get; set; }
    }
}
