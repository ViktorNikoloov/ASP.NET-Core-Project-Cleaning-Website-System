namespace CleaningWeb.Web.Controllers
{
    using CleaningWeb.Services.Data.About;
    using CleaningWeb.Web.ViewModels.About;
    using Microsoft.AspNetCore.Mvc;

    public class AboutController : BaseController
    {
        private readonly IAboutService aboutService;

        public AboutController(IAboutService aboutService)
        {
            this.aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var viewModel = new AboutViewModel
            {
                BusinessViewModel = this.aboutService.GetBusinessViewModel<BusinessViewModel>(),
                CompanyViewModel = this.aboutService.GetCompanyViewModel<CompanyViewModel>(),
            };

            return this.View(viewModel);
        }
    }
}
