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
    public class TakeLeaveRepository : ITakeLeaveRepository
    {
        MyContext myContext = new MyContext();
        TakeLeave takeLeave = new TakeLeave();
        Log log = new Log();

        private bool status = false;
        public bool Delete(int? Id)
        {
            var result = 0;
            var getTakeLeaveId = Get(Id);
            getTakeLeaveId.IsDelete = true;
            getTakeLeaveId.DeleteDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }

            return status;
        }

        public List<TakeLeave> Get()
        {
           var getDataTakeLeave = myContext.TakeLeaves.Where(x => x.IsDelete == false).ToList();
            return getDataTakeLeave;
        }

        public TakeLeave Get(int? Id)
        {
            var getDataTakeLeave = myContext.TakeLeaves.Find(Id);
            return getDataTakeLeave;
        }

        public bool Insert(TakeLeaveParam takeLeaveParam)
        {
            var getEmployee = myContext.Employees.Find(takeLeaveParam.Employee_Id);
            var getLeave = myContext.Leaves.Find(takeLeaveParam.Leave_Id);

            var result = 0;
            takeLeave.Description = takeLeaveParam.Description;
            takeLeave.DateStart = takeLeaveParam.DateStart;
            takeLeave.DateEnd = takeLeaveParam.DateEnd;
            takeLeave.ApprovalStatus = takeLeaveParam.ApprovalStatus;
            takeLeave.Difference = takeLeaveParam.Difference;
            takeLeave.DateStartSpecial = takeLeaveParam.DateStartSpecial;
            takeLeave.DateEndSpecial = takeLeaveParam.DateEndSpecial;
            takeLeave.DifferenceSpecial = takeLeaveParam.DifferenceSpecial;
            takeLeave.CreateDate = DateTimeOffset.UtcNow.LocalDateTime;
            takeLeave.Employees = getEmployee;
            takeLeave.Leaves = getLeave;

            myContext.TakeLeaves.Add(takeLeave);
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(int? Id, TakeLeaveParam takeLeaveParam)
        {
            var getEmployee = myContext.Employees.Find(takeLeaveParam.Employee_Id);
            var getLeave = myContext.Leaves.Find(takeLeaveParam.Leave_Id);

            var result = 0;
            var getDataTakeLeave = Get(Id);
            getDataTakeLeave.Description = takeLeaveParam.Description;
            getDataTakeLeave.DateStart = takeLeaveParam.DateStart;
            getDataTakeLeave.DateEnd = takeLeaveParam.DateEnd;
            getDataTakeLeave.ApprovalStatus = takeLeaveParam.ApprovalStatus;
            getDataTakeLeave.Difference = takeLeaveParam.Difference;
            getDataTakeLeave.DateStartSpecial = takeLeaveParam.DateStartSpecial;
            getDataTakeLeave.DateEndSpecial = takeLeaveParam.DateEndSpecial;
            getDataTakeLeave.DifferenceSpecial = takeLeaveParam.DifferenceSpecial;
            getDataTakeLeave.CreateDate = DateTimeOffset.UtcNow.LocalDateTime;
            getDataTakeLeave.Employees = getEmployee;
            getDataTakeLeave.Leaves = getLeave;

            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Approve(int? Id, TakeLeaveParam takeLeaveParam)
        {
            var result = 0;
            var getDataTakeLeave = Get(Id);
            getDataTakeLeave.ApprovalStatus = takeLeaveParam.ApprovalStatus;

            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
