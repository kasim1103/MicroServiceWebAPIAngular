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
    public class RegencyRepository : IRegencyRepository
    {
        bool status = false;
        MyContext myContext = new MyContext();
        Regency regency = new Regency();
        public bool Delete(int? Id)
        {
            var result = 0;
            Regency regency = Get(Id);
            regency.IsDelete = true;
            regency.DeleteDate = DateTimeOffset.Now.ToLocalTime();
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Regency> Get()
        {
            var getDataRegency = myContext.Regencies.Where(x => x.IsDelete == false).ToList();
            return getDataRegency;
        }

        public Regency Get(int? Id)
        {
            var getDataRegency = myContext.Regencies.Find(Id);
            return getDataRegency;
        }

        public bool Insert(RegencyParam regencyParam)
        {
            var getDataProvince = myContext.Provinces.Find(regencyParam.Provinces_Id);
            var result = 0;
            regency.Name = regencyParam.Name;
            regency.Provinces = getDataProvince;
            regency.CreateDate = DateTimeOffset.Now.LocalDateTime;
            myContext.Regencies.Add(regency);
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(int? Id, RegencyParam regencyParam)
        {
            var getDataRegency = myContext.Regencies.Find(Id);
            var getDataProvince = myContext.Provinces.Find(regencyParam.Provinces_Id);
            var result = 0;
            getDataRegency.Name = regencyParam.Name;
            getDataRegency.Provinces = getDataProvince;
            getDataRegency.UpdateDate = DateTimeOffset.Now.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Regency> GetRegency(int? Id)
        {
            var getDataRegency = myContext.Regencies.Where(x => x.Provinces.Id == Id && x.IsDelete == false ).ToList();
            return getDataRegency;
        }
    }
}