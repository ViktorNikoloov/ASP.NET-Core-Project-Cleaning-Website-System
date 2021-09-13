namespace CleaningWeb.Services.Data.Appointment
{
    using System.Threading.Tasks;

    using CleaningWeb.Web.ViewModels.Appointment;

    public interface IAppointmentsService
    {
        Task<bool> MakeAppointmentAsync(MakeAppointmentInputModel input);
    }
}
