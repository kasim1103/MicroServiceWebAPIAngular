using LeaveRequestWebAPI.Core.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.DataAccess.Model
{
    public class TakeLeave:BaseModel
    {
        public string Description { get; set; }
        public DateTimeOffset DateStart { get; set; }
        public DateTimeOffset DateEnd { get; set; }
        public string ApprovalStatus { get; set; }
        public int Difference { get; set; }
        public DateTimeOffset DateStartSpecial { get; set; }
        public DateTimeOffset DateEndSpecial { get; set; }
        public int DifferenceSpecial { get; set; }
        public virtual Employee Employees { get; set; }
        public virtual Leave Leaves { get; set; }
    }
}
