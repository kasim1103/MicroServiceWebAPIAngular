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
    public class DivisionService :IDivisionService
    {
        private readonly IDivisionRepository _divisionRepository;
        public DivisionService(IDivisionRepository divisionRepository)
        {
            _divisionRepository = divisionRepository;
        }

        bool status = false;
        public bool Delete(int? Id)
        {
            var idDel = Get(Id);
            if (idDel != null)
            {
                status = _divisionRepository.Delete(Id);
            }
            return status;
        }

        public List<Division> Get()
        {
            return _divisionRepository.Get().ToList();
        }

        public Division Get(int? Id)
        {
            return _divisionRepository.Get(Id);
        }

        public bool Insert(DivisionParam divisionParam)
        {
            if (divisionParam != null)
            {
                status = _divisionRepository.Insert(divisionParam);
            }
            return status;
        }

        public bool Update(int? Id, DivisionParam divisionParam)
        {
            if (Id != null && divisionParam != null)
            {
                status = _divisionRepository.Update(Id, divisionParam);
            }
            return status;
        }
    }
}
