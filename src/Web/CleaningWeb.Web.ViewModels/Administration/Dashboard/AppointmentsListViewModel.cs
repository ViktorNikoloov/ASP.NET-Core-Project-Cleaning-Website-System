namespace CleaningWeb.Web.ViewModels.Administration.Dashboard
{
    using System.Collections.Generic;

    public class AppointmentsListViewModel
    {
        public IEnumerable<AppointmentInListViewModel> AllAppointments { get; set; }
    }
}
