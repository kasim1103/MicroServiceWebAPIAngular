using LeaveRequestWebAPI.DataAccess.Context;
using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.Common.Repository.Master
{
    public class DistrictRepository : IDistrictRepository
    {
        MyContext myContext = new MyContext();
        District district = new District();

        private bool status = false;
        public bool Delete(int? Id)
        {
            var result = 0;
            var getIdDistrict = Get(Id);
            getIdDistrict.IsDelete = true;
            getIdDistrict.DeleteDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;

        }

        public List<District> Get()
        {
            return myContext.Districts.Where(x => x.IsDelete == false).ToList();
        }

        public District Get(int? Id)
        {
            return myContext.Districts.Find(Id);
        }

        public bool Insert(DistrictParam districtParam)
        {
            var result = 0;
            district.Name = districtParam.Name;
            district.Regencies = myContext.Regencies.Find(districtParam.Regencies_Id);
            district.CreateDate = DateTimeOffset.UtcNow.LocalDateTime;
            myContext.Districts.Add(district);
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(int? Id, DistrictParam districtParam)
        {
            var result = 0;
            var District = Get(Id);
            District.Name = districtParam.Name;
            District.Regencies = myContext.Regencies.Find(districtParam.Regencies_Id);
            District.UpdateDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<District> GetDistrict(int? Id)
        {
            var getDataDistrict = myContext.Districts.Where(x => x.Regencies.Id == Id && x.IsDelete == false).ToList();
            return getDataDistrict;
        }
    }
}
