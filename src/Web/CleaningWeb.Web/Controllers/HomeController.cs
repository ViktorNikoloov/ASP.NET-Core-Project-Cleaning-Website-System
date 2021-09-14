namespace CleaningWeb.Web.Controllers
{
    using System.Diagnostics;

    using CleaningWeb.Services.Data.Business;
    using CleaningWeb.Services.Data.Company;
    using CleaningWeb.Services.Data.Service;
    using CleaningWeb.Web.ViewModels;
    using CleaningWeb.Web.ViewModels.About;
    using CleaningWeb.Web.ViewModels.Home;
    using CleaningWeb.Web.ViewModels.Service;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ICompanyService companyService;
        private readonly IBusinessService businessService;
        private readonly IServiceService serviceService;

        public HomeController(
            ICompanyService companyService,
            IBusinessService businessService,
            IServiceService serviceService)
        {
            this.companyService = companyService;
            this.businessService = businessService;
            this.serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                BusinessViewModel = this.businessService.GetBusinessViewModel<BusinessViewModel>(),
                CompanyViewModel = this.companyService.GetCompanyViewModel<CompanyViewModel>(),
                Services = this.serviceService.GetAllInFormationForService<ServiceViewModel>(),
            };

            return this.View(viewModel);
        }

        public IActionResult CreateAppointment()
        {
            return this.View();
        }

        //[HttpPost]
        //public IActionResult CreateAppointment()
        //{
        //    return this.View();
        //}

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
