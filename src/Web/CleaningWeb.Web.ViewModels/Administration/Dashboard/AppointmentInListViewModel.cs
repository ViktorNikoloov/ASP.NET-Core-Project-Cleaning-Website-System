namespace CleaningWeb.Web.ViewModels.Administration.Dashboard
{
    using System;

    using CleaningWeb.Data.Models;
    using CleaningWeb.Services.Mapping;

    public class AppointmentInListViewModel : IMapFrom<Appointment>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
