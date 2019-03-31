using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.Common.Repository
{
    public interface IPositionRepository
    {
        bool Insert(PositionParam positionParam);
        bool Update(int? Id, PositionParam positionParam);
        bool Delete(int? Id);
        List<Position> Get();
        Position Get(int? Id);
    }
}
