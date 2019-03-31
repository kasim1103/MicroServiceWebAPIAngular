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
    public class ReligionService : IReligionService
    {
        private readonly IReligionRepository _religionRepository;
        public ReligionService(IReligionRepository religionRepository)
        {
            _religionRepository = religionRepository;
        }
        bool status = false;
        public bool Delete(int? Id)
        {
            var idDel = Get(Id);
            if (idDel != null)
            {
                status = _religionRepository.Delete(Id);
            }
            return status;
        }

        public List<Religion> Get()
        {
            return _religionRepository.Get();
        }

        public Religion Get(int? Id)
        {
            var getReligionId = _religionRepository.Get(Id);
            if (Id == null)
            {
                Console.WriteLine("Insert Id");
                Console.Read();
            }
            return getReligionId;
        }

        public bool Insert(ReligionParam religionParam)
        {
            if (religionParam == null)
            {
                Console.WriteLine("Insert Name");
                Console.Read();
            }
            else
            {
                _religionRepository.Insert(religionParam);
                status = true;
                Console.WriteLine("Success");
            }
            return status;
        }

        public bool Update(int? Id, ReligionParam religionParam)
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
                _religionRepository.Update(Id, religionParam);
                status = true;
                Console.WriteLine("update Success");
            }
            return status;
        }
    }
}
