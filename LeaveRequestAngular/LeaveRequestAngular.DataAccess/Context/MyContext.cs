using LeaveRequestWebAPI.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.DataAccess.Context
{
    public class MyContext:DbContext
    {
        public MyContext() : base("MyContext") { }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Regency> Regencies { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Village> Villages { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<TakeLeave> TakeLeaves { get; set; }
    }
}
