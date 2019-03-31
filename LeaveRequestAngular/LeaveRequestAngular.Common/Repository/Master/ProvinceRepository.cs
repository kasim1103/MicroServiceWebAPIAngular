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
    public class ProvinceRepository : IProvinceRepository
    {
        MyContext myContext = new MyContext();
        Province province = new Province();

        private bool status = false;
        public bool Delete(int? Id)
        {
            var result = 0;
            var ProvinceId = Get(Id);
            ProvinceId.IsDelete = true;
            ProvinceId.DeleteDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }

            return status;
        }

        public List<Province> Get()
        {
            return myContext.Provinces.Where(x => x.IsDelete == false).ToList();
        }

        public Province Get(int? Id)
        {
            return myContext.Provinces.Find(Id);
        }

        public bool Insert(ProvinceParam provinceParam)
        {
            var result = 0;
            province.Name = provinceParam.Name;
            province.CreateDate = DateTimeOffset.UtcNow.LocalDateTime;
            myContext.Provinces.Add(province);
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(int? Id, ProvinceParam provinceParam)
        {
            var result = 0;
            var ProvinceId = Get(Id);
            ProvinceId.Name = provinceParam.Name;
            ProvinceId.UpdateDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
