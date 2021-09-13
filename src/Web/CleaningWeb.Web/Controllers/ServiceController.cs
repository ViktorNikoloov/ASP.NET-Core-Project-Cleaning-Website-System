namespace CleaningWeb.Web.Controllers
{
    using CleaningWeb.Services.Data.Service;
    using CleaningWeb.Web.ViewModels.Service;
    using Microsoft.AspNetCore.Mvc;

    public class ServiceController : BaseController
    {
        private readonly IServiceService serviceService;

        public ServiceController(IServiceService serviceService)
        {
            this.serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var serviceModel = new ServiceListViewModel
            {
                Services = this.serviceService.GetAllInFormationForService<ServiceViewModel>(),
            };

            return this.View(serviceModel);
        }

        public IActionResult OfficeCleaning()
        {
            return this.View();
        }

        public IActionResult PoolCleaning()
        {
            return this.View();
        }

        public IActionResult CarpetCleaning()
        {
            return this.View();
        }

        public IActionResult KitchenCleaning()
        {
            return this.View();
        }

        public IActionResult GardenCleaning()
        {
            return this.View();
        }

        public IActionResult WindowCleaning()
        {
            return this.View();
        }
    }
}
