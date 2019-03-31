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
    public class DistrictService : IDistrictService
    {
        private readonly IDistrictRepository _districtRepository;
        public DistrictService(DistrictRepository districtRepository)
        {
            _districtRepository = districtRepository;
        }
        bool status = false;
        public bool Delete(int? Id)
        {
            var idDel = Get(Id);
            if (idDel != null)
            {
                status = _districtRepository.Delete(Id);
            }
            return status;
        }

        public List<District> Get()
        {
            return _districtRepository.Get();
        }

        public District Get(int? Id)
        {
            return _districtRepository.Get(Id);
        }

        public bool Insert(DistrictParam districtParam)
        {
            if (districtParam != null)
            {
                status = _districtRepository.Insert(districtParam);
            }
            return status;
        }

        public bool Update(int? Id, DistrictParam districtParam)
        {
            if (Id != null && districtParam != null)
            {
                status = _districtRepository.Update(Id, districtParam);
            }
            return status;
        }

        public List<District> GetDistrict(int? Id)
        {
            return _districtRepository.GetDistrict(Id);
        }
    }
}
