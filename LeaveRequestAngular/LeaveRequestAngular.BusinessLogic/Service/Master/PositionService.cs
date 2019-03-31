using LeaveRequestWebAPI.Common.Repository;
using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestWebAPI.BussinessLogic.Service.Master
{
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _positionRepository;
        public PositionService(IPositionRepository positionRepository)
        {
            _positionRepository = positionRepository;
        }

        bool status = false;
        public bool Delete(int? Id)
        {
            var idDel = Get(Id);
            if (idDel != null)
            {
                status = _positionRepository.Delete(Id);
            }
            return status;
        }

        public List<Position> Get()
        {
            return _positionRepository.Get().ToList();
        }

        public Position Get(int? Id)
        {
            return _positionRepository.Get(Id);
        }

        public bool Insert(PositionParam positionParam)
        {
            if (positionParam != null)
            {
                status = _positionRepository.Insert(positionParam);
            }
            return status;
        }

        public bool Update(int? Id, PositionParam positionParam)
        {
            if (Id != null && positionParam != null)
            {
                status = _positionRepository.Update(Id, positionParam);
            }
            return status;
        }
    }
}
