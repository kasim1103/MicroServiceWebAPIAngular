using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequestWebAPI.DataAccess.Model;
using LeaveRequestWebAPI.DataAccess.Param;
using LeaveRequestWebAPI.Common.Repository;

namespace LeaveRequestWebAPI.BussinessLogic.Service.Master
{
    public class RegencyService : IRegencyService
    {
        bool status = false;
        private readonly IRegencyRepository _regencyRepository;

        public RegencyService(IRegencyRepository regencyRepository)
        {
            _regencyRepository = regencyRepository;
        }
        public bool Delete(int? Id)
        {
            if (Id == null)
            {
                Console.WriteLine("Insert Id");
                Console.Read();
            }
            else if (Id == ' ')
            {
                Console.WriteLine("Dont Insert Blank Caracter");
                Console.Read();
            }
            else
            {
                status = _regencyRepository.Delete(Id);
                Console.WriteLine("Success");
            }
            return status;
        }

        public List<Regency> Get()
        {
            return _regencyRepository.Get();
        }

        public Regency Get(int? Id)
        {
            var getRegencyId = _regencyRepository.Get(Id);
            if (Id == null)
            {
                Console.WriteLine("Insert Id");
                Console.Read();
            }
            return getRegencyId;
        }

        public List<Regency> GetRegency(int? Id)
        {
            return _regencyRepository.GetRegency(Id);
        }

        public bool Insert(RegencyParam regencyParam)
        {
            if (regencyParam == null)
            {
                Console.WriteLine("Insert Name");
                Console.Read();
            }
            else
            {
                status = _regencyRepository.Insert(regencyParam);
                Console.WriteLine("Success");
            }
            return status;
        }

        public bool Update(int? Id, RegencyParam regencyParam)
        {
            if (Id == null)
            {
                Console.WriteLine("Insert Id");
                Console.Read();
            }
            else if (Id == ' ')
            {
                Console.WriteLine("Dont Insert Blank Caracter");
                Console.Read();
            }
            else
            {
                status = _regencyRepository.Update(Id, regencyParam);
                Console.WriteLine("update Success");
            }
            return status;
        }
    }
}
