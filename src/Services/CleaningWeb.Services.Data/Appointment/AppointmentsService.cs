namespace CleaningWeb.Services.Data.Appointment
{
    using System;
    using System.Threading.Tasks;

    using CleaningWeb.Data.Common.Repositories;
    using CleaningWeb.Data.Models;
    using CleaningWeb.Web.ViewModels.Appointment;

    public class AppointmentsService : IAppointmentsService
    {
        private readonly IRepository<Appointment> appoinmentRepository;

        public AppointmentsService(IRepository<Appointment> appoinmentRepository)
        {
            this.appoinmentRepository = appoinmentRepository;
        }

        public async Task<bool> MakeAppointmentAsync(MakeAppointmentInputModel input)
        {
            var appointment = new Appointment
            {
                Name = input.Name,
                Phone = input.Phone,
                Description = input.Description,
                CreatedOn = DateTime.UtcNow,
            };

            if (appointment == null)
            {
                return false;
            }

            await this.appoinmentRepository.AddAsync(appointment);
            await this.appoinmentRepository.SaveChangesAsync();

            return true;
        }
    }
}
