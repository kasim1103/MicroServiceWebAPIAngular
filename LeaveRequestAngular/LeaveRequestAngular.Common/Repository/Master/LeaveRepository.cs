using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using LeaveRequestWebAPI.DataAccess.Context;

namespace LeaveRequestWebAPI.Common.Repository.Master
{
    public class LeaveRepository : ILeaveRepository
    {
        MyContext myContext = new MyContext();
        Leave leave = new Leave();

        private bool status = false;
        public bool Delete(int? Id)
        {
            var result = 0;
            var getLeaveId = Get(Id);
            getLeaveId.IsDelete = true;
            getLeaveId.DeleteDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }

            return status;
        }

        public List<Leave> Get()
        {
            var getDataLeave = myContext.Leaves.Where(x => x.IsDelete == false).ToList();
            return getDataLeave;
        }

        public Leave Get(int? Id)
        {
            var getDataLeave = myContext.Leaves.Find(Id);
            return getDataLeave;
        }

        public bool Insert(LeaveParam leaveParam)
        {
            var result = 0;
            leave.Name = leaveParam.Name;
            leave.Status = leaveParam.Status;
            leave.Days = leaveParam.Days;
            leave.CreateDate = DateTimeOffset.UtcNow.LocalDateTime;
            myContext.Leaves.Add(leave);
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(int? Id, LeaveParam leaveParam)
        {
            var result = 0;
            var getDataLeave = Get(Id);
            getDataLeave.Name = leaveParam.Name;
            getDataLeave.Status = leaveParam.Status;
            getDataLeave.Days = leaveParam.Days;
            getDataLeave.UpdateDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        List<Leave> ILeaveRepository.GetType(string Type)
        {
            var getDataLeave = myContext.Leaves.Where(x => x.IsDelete == false && x.Status == Type).ToList();
            return getDataLeave;
        }
    }
}
