namespace CleaningWeb.Services.Data.Administator
{
    using System.Collections.Generic;
    using System.Linq;

    using CleaningWeb.Data.Common.Repositories;
    using CleaningWeb.Data.Models;
    using CleaningWeb.Services.Mapping;

    public class AdministratorService : IAdministratorService
    {
        private readonly IRepository<Appointment> appointmentRepository;

        public AdministratorService(IRepository<Appointment> appointmentRepository)
        {
            this.appointmentRepository = appointmentRepository;
        }

        public IEnumerable<T> GetAllAppointments<T>()
        => this.appointmentRepository.AllAsNoTracking().OrderBy(x => x.CreatedOn).To<T>().ToList();
    }
}
