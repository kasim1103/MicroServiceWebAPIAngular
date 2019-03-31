using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.DataAccess.Param
{
    public class LeaveParam
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public int Days { get; set; }
    }
}
