using LeaveRequestWebAPI.Common.Repository;
using LeaveRequestWebAPI.Common.Repository.Master;
using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.BussinessLogic.Service.Master
{
    public class VillageService : IVillageService
    {
        private readonly IVillageRepository _villageRepository;
        public VillageService (VillageRepository villageRepository)
        {
            _villageRepository = villageRepository;
        }
        bool status = false;
        public bool Delete(int? Id)
        {
            var idDel = Get(Id);
            if (idDel != null)
            {
                status = _villageRepository.Delete(Id);
            }
            return status;
        }

        public List<Village> Get()
        {
            return _villageRepository.Get();
        }

        public Village Get(int? Id)
        {
            return _villageRepository.Get(Id);
        }

        public bool Insert(VillageParam villageParam)
        {
            if (villageParam != null)
            {
                status = _villageRepository.Insert(villageParam);
            }
            return status;
        }

        public bool Update(int? Id, VillageParam villageParam)
        {
            if (Id != null && villageParam != null)
            {
                status = _villageRepository.Update(Id, villageParam);
            }
            return status;
        }

        public List<Village> GetVillage(int? Id)
        {
            return _villageRepository.GetVillage(Id);
        }
    }
}
