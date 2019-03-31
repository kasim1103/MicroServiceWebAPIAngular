using LeaveRequestWebAPI.Core.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.DataAccess.Model
{
    public class Employee : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Marriage { get; set; }
        public int ChildrenTotal { get; set; }
        public int LastYear { get; set; }
        public int ThisYear { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Picture { get; set; }
        public DateTimeOffset JoinDate { get; set; }
        public virtual Religion Religions { get; set; }
        public virtual Village Villages { get; set; }
        public virtual Position Positions { get; set; }
        public virtual Division Divisions { get; set; }
        public virtual Employee Managers { get; set; }
    }
}
