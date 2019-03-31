using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.DataAccess.Param
{
    public class EmployeeParam
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
        public int Religions_Id { get; set; }
        public int Villages_Id { get; set; }
        public int Positions_Id { get; set; }
        public int Divisions_Id { get; set; }
        public int Managers_Id { get; set; }
    }
}
