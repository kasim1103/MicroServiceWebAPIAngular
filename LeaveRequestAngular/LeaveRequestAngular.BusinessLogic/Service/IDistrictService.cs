using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.BussinessLogic.Service
{
    public interface IDistrictService
    {
        bool Insert(DistrictParam districtParam);
        bool Update(int? Id, DistrictParam districtParam);
        bool Delete(int? Id);
        List<District> Get();
        List<District> GetDistrict(int? Id);
        District Get(int? Id);
    }
}
