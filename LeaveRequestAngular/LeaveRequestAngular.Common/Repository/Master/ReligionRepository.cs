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
    public class ReligionRepository : IReligionRepository
    {
        MyContext myContext = new MyContext();
        Religion religion = new Religion();

        private bool status = false;
        public bool Delete(int? Id)
        {
            var result = 0;
            var getReligionId = Get(Id);
            getReligionId.IsDelete = true;
            getReligionId.DeleteDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }

            return status;
        }

        public List<Religion> Get()
        {
            var getDataReligion = myContext.Religions.Where(x => x.IsDelete == false).ToList();
            return getDataReligion;
        }

        public Religion Get(int? Id)
        {
            var getDataReligion = myContext.Religions.Find(Id);
            return getDataReligion;
        }

        public bool Insert(ReligionParam religionParam)
        {
            var result = 0;
            religion.Name = religionParam.Name;
            religion.CreateDate = DateTimeOffset.UtcNow.LocalDateTime;
            myContext.Religions.Add(religion);
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(int? Id, ReligionParam religionParam)
        {
            var result = 0;
            var getDataReligion = Get(Id);
            getDataReligion.Name = religionParam.Name;
            getDataReligion.UpdateDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
