namespace CleaningWeb.Web.Controllers
{
    using CleaningWeb.Services.Data.Business;
    using CleaningWeb.Services.Data.Company;
    using CleaningWeb.Web.ViewModels.About;

    using Microsoft.AspNetCore.Mvc;

    public class AboutController : BaseController
    {
        private readonly ICompanyService companyService;
        private readonly IBusinessService businessService;

        public AboutController(
            ICompanyService companyService,
            IBusinessService businessService)
        {
            this.companyService = companyService;
            this.businessService = businessService;
        }

        public IActionResult Index()
        {
            var viewModel = new AboutViewModel
            {
                BusinessViewModel = this.businessService.GetBusinessViewModel<BusinessViewModel>(),
                CompanyViewModel = this.companyService.GetCompanyViewModel<CompanyViewModel>(),
            };

            return this.View(viewModel);
        }
    }
}
