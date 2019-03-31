using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.BussinessLogic.Service
{
    public interface IRegencyService
    {
        bool Insert(RegencyParam regencyParam);
        bool Update(int? Id, RegencyParam regencyParam);
        bool Delete(int? Id);
        List<Regency> Get();
        Regency Get(int? Id);
        List<Regency> GetRegency(int? Id);
    }
}
