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
    public class PositionRepository : IPositionRepository
    {
        MyContext myContext = new MyContext();
        Position position = new Position();

        private bool status = false;
        public bool Delete(int? Id)
        {
            var result = 0;
            var PositionId = Get(Id);
            PositionId.IsDelete = true;
            PositionId.DeleteDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }

            return status;
        }

        public List<Position> Get()
        {
            return myContext.Positions.Where(x => x.IsDelete == false).ToList();
        }

        public Position Get(int? Id)
        {
            return myContext.Positions.Find(Id);
        }

        public bool Insert(PositionParam positionParam)
        {
            var result = 0;
            position.Name = positionParam.Name;
            position.CreateDate = DateTimeOffset.UtcNow.LocalDateTime;
            myContext.Positions.Add(position);
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool Update(int? Id, PositionParam positionParam)
        {
            var result = 0;
            var PositionId = Get(Id);
            PositionId.Name = positionParam.Name;
            PositionId.UpdateDate = DateTimeOffset.UtcNow.LocalDateTime;
            result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
