using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using LeaveRequestWebAPI.Common.Repository;
using LeaveRequestWebAPI.Common.Repository.Master;

namespace LeaveRequestWebAPI.BussinessLogic.Service.Master
{
    public class TakeLeaveService : ITakeLeaveService
    {
        private readonly ITakeLeaveRepository _takeLeaveRepository;
        public TakeLeaveService(TakeLeaveRepository takeLeaveRepository)
        {
            _takeLeaveRepository = takeLeaveRepository;
        }
        private bool status = false;

        public bool Delete(int? Id)
        {
            if (Id == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                status = _takeLeaveRepository.Delete(Id);
            }
            return status;
        }

        public List<TakeLeave> Get()
        {
            return _takeLeaveRepository.Get();
        }

        public TakeLeave Get(int? Id)
        {
            var getDataTakeLeave = _takeLeaveRepository.Get(Id);
            if (Id == null)
            {
                throw new NullReferenceException();
            }
            return getDataTakeLeave;
        }

        public bool Insert(TakeLeaveParam takeLeaveParam)
        {
            if(takeLeaveParam == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                status = _takeLeaveRepository.Insert(takeLeaveParam);
            }
            return status;
        }

        public bool Update(int? Id, TakeLeaveParam takeLeaveParam)
        {
            if (Id == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                status = _takeLeaveRepository.Update(Id, takeLeaveParam);
            }
            return status;
        }

        public bool Approve(int? Id, TakeLeaveParam takeLeaveParam)
        {
            if (Id == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                status = _takeLeaveRepository.Approve(Id, takeLeaveParam);
            }
            return status;
        }
    }
}
