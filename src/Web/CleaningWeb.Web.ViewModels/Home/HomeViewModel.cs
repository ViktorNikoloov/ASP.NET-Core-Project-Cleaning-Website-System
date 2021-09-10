namespace CleaningWeb.Web.ViewModels.Home
{
    using CleaningWeb.Web.ViewModels.About;
    using CleaningWeb.Web.ViewModels.Appointmen;

    public class HomeViewModel
    {
        public AppointmentViewModel AppointmentViewModel { get; set; }

        public BusinessViewModel BusinessViewModel { get; set; }

        public CompanyViewModel CompanyViewModel { get; set; }
    }
}
