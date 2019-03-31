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
    public class VillageRepository : IVillageRepository
    {
        MyContext myContext = new MyContext();
        Village Village = new Village();

        private bool status = false;
        public bool Delete(int? Id)
        {
            var result = 0;
            var getIdVillage = Get(Id);
            getIdVillage.IsDelete = true;
            getIdVillage.DeleteDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;

        }

        public List<Village> Get()
        {
            return myContext.Villages.Where(x => x.IsDelete == false).ToList();
        }

        public Village Get(int? Id)
        {
            return myContext.Villages.Find(Id);
        }

        public bool Insert(VillageParam villageParam)
        {
            var result = 0;
            Village.Name = villageParam.Name;
            Village.Districts = myContext.Districts.Find(villageParam.Districts_Id);
            Village.CreateDate = DateTimeOffset.UtcNow.LocalDateTime;
            myContext.Villages.Add(Village);
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(int? Id, VillageParam villageParam)
        {
            var result = 0;
            var Village = Get(Id);
            Village.Name = villageParam.Name;
            Village.Districts = myContext.Districts.Find(villageParam.Districts_Id);
            Village.UpdateDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Village> GetVillage(int? Id)
        {
            var getDataVillage = myContext.Villages.Where(x => x.Districts.Id == Id && x.IsDelete == false).ToList();
            return getDataVillage;
        }
    }
}
