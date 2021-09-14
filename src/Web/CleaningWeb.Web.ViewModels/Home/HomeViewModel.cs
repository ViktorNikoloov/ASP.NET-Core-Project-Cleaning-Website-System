namespace CleaningWeb.Web.ViewModels.Home
{
    using System.Collections.Generic;

    using CleaningWeb.Web.ViewModels.About;
    using CleaningWeb.Web.ViewModels.Appointmen;

    public class HomeViewModel
    {
        public MakeAppointmentInputModel AppointmentViewModel { get; set; }

        public BusinessViewModel BusinessViewModel { get; set; }

        public CompanyViewModel CompanyViewModel { get; set; }

        public IEnumerable<ServiceViewModel> Services { get; set; }
    }
}
