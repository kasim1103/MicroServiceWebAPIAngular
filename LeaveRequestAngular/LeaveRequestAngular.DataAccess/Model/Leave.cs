using LeaveRequestWebAPI.Core.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.DataAccess.Model
{
    public class Leave:BaseModel
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public int Days { get; set; }
    }
}
