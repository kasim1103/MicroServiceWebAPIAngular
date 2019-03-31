using LeaveRequestWebAPI.BussinessLogic.Service;
using LeaveRequestWebAPI.BussinessLogic.Service.Master;
using LeaveRequestWebAPI.Common.Repository;
using LeaveRequestWebAPI.Common.Repository.Master;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace LeaveRequestAngular.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            //this Service Only
            container.RegisterType<IProvinceService, ProvinceService>();
            container.RegisterType<IRegencyService, RegencyService>();
            container.RegisterType<IDistrictService, DistrictService>();
            container.RegisterType<IVillageService, VillageService>();
            container.RegisterType<IDivisionService, DivisionService>();
            container.RegisterType<IPositionService, PositionService>();
            container.RegisterType<IReligionService, ReligionService>();
            container.RegisterType<IEmployeeService, EmployeeService>();
            container.RegisterType<ILogService, LogService>();
            container.RegisterType<IHolidayService, HolidayService>();
            container.RegisterType<ILeaveService, LeaveService>();
            container.RegisterType<ITakeLeaveService, ITakeLeaveService>();

            //this Repository Only
            container.RegisterType<IProvinceRepository, ProvinceRepository>();
            container.RegisterType<IRegencyRepository, RegencyRepository>();
            container.RegisterType<IDistrictRepository, DistrictRepository>();
            container.RegisterType<IVillageRepository, VillageRepository>();
            container.RegisterType<IDivisionRepository, DivisionRepository>();
            container.RegisterType<IPositionRepository, PositionRepository>();
            container.RegisterType<IReligionRepository, ReligionRepository>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<ILogRepository, LogRepository>();
            container.RegisterType<IHolidayRepository, HolidayRepository>();
            container.RegisterType<ILeaveRepository, LeaveRepository>();
            container.RegisterType<ITakeLeaveRepository, TakeLeaveRepository>();


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}