namespace CleaningWeb.Web.ViewModels.Home
{
    using CleaningWeb.Web.ViewModels.About;
    using CleaningWeb.Web.ViewModels.Appointment;

    public class HomeViewModel
    {
        public MakeAppointmentInputModel AppointmentViewModel { get; set; }

        public BusinessViewModel BusinessViewModel { get; set; }

        public CompanyViewModel CompanyViewModel { get; set; }
    }
}
