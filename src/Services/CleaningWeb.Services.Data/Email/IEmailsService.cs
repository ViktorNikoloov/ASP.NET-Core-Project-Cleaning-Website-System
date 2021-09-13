namespace CleaningWeb.Services.Data.Email
{
    using CleaningWeb.Web.ViewModels.Appointment;

    public interface IEmailsService
    {
        string GenerateAppointmentEmail(MakeAppointmentInputModel model);
    }
}
