using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.BussinessLogic.Service
{
    public interface IProvinceService
    {
        bool Insert(ProvinceParam provinceParam);
        bool Update(int? Id, ProvinceParam provinceParam);
        bool Delete(int? Id);
        List<Province> Get();
        Province Get(int? Id);
    }
}
