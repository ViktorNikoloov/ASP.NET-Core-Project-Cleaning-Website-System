namespace CleaningWeb.Web.Areas.Administration.Controllers
{
    using CleaningWeb.Services.Data;
    using CleaningWeb.Services.Data.Administator;
    using CleaningWeb.Web.ViewModels.Administration.Dashboard;

    using Microsoft.AspNetCore.Mvc;

    public class DashboardController : AdministrationController
    {
        private readonly IAdministratorService administratorService;

        public DashboardController(IAdministratorService administratorService)
        {
            this.administratorService = administratorService;
        }

        public IActionResult RegulationPage()
        {
            return this.View();
        }

        public IActionResult CollectedInformation()
        {
            return this.View();
        }

        public IActionResult MakeChanges()
        {
            return this.View();
        }

        public IActionResult AllAppointments()
        {
            var viewModel = new AppointmentsListViewModel
            {
                AllAppointments = this.administratorService.GetAllAppointments<AppointmentInListViewModel>(),
            };

            return this.View(viewModel);
        }
    }
}
