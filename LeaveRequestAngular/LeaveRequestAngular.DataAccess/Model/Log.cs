using LeaveRequestWebAPI.Core.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.DataAccess.Model
{
    public class Log:BaseModel
    {
        public DateTimeOffset LogDate { get; set; }
        public virtual Employee Employees { get; set; }
    }
}
