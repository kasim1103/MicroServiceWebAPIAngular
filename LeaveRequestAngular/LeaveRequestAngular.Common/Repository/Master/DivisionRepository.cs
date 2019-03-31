using LeaveRequestWebAPI.DataAccess.Context;
using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.Common.Repository.Master
{
    public class DivisionRepository : IDivisionRepository
    {
        MyContext myContext = new MyContext();
        Division division = new Division();

        private bool status = false;
        public bool Delete(int? Id)
        {
            var result = 0;
            var DivisionId = Get(Id);
            DivisionId.IsDelete = true;
            DivisionId.DeleteDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }

            return status;
        }

        public List<Division> Get()
        {
            return myContext.Divisions.Where(x => x.IsDelete == false).ToList();
        }

        public Division Get(int? Id)
        {
            return myContext.Divisions.Find(Id);
        }

        public bool Insert(DivisionParam divisionParam)
        {
            var result = 0;
            division.Name = divisionParam.Name;
            division.CreateDate = DateTimeOffset.UtcNow.LocalDateTime;
            myContext.Divisions.Add(division);
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(int? Id, DivisionParam divisionParam)
        {
            var result = 0;
            var DivisionId = Get(Id);
            DivisionId.Name = divisionParam.Name;
            DivisionId.UpdateDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
