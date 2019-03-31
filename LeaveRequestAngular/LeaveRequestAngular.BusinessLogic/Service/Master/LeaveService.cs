using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using LeaveRequestWebAPI.Common.Repository;

namespace LeaveRequestWebAPI.BussinessLogic.Service.Master
{
    public class LeaveService : ILeaveService
    {
        private readonly ILeaveRepository _leaveRepository;
        public LeaveService(ILeaveRepository leaveRepository)
        {
            _leaveRepository = leaveRepository;
        }

        bool status = false;
        public bool Delete(int? Id)
        {
            var idDel = Get(Id);
            if (idDel != null)
            {
                status = _leaveRepository.Delete(Id);
            }
            return status;
        }

        public List<Leave> Get()
        {
            return _leaveRepository.Get();
        }

        public Leave Get(int? Id)
        {
            var getLeaveId = _leaveRepository.Get(Id);
            if (Id == null)
            {
                Console.WriteLine("Insert Id");
                Console.Read();
            }
            return getLeaveId;
        }

        public bool Insert(LeaveParam leaveParam)
        {
            if (leaveParam == null)
            {
                Console.WriteLine("Insert Name");
                Console.Read();
            }
            else
            {
                _leaveRepository.Insert(leaveParam);
                status = true;
                Console.WriteLine("Success");
            }
            return status;
        }

        public bool Update(int? Id, LeaveParam leaveParam)
        {
            if (Id == null)
            {
                Console.WriteLine("Insert Id");
                Console.Read();
            }
            else if (Id == ' ')
            {
                Console.WriteLine("Dont Insert Blank Caracter");
                Console.Read();
            }
            else
            {
                _leaveRepository.Update(Id, leaveParam);
                status = true;
                Console.WriteLine("update Success");
            }
            return status;
        }

        public List<Leave> GetType(string Type)
        {
            return _leaveRepository.GetType(Type);
        }
    }
}
