namespace CleaningWeb.Services.Data.Email
{
    using System.Text;

    using CleaningWeb.Web.ViewModels.Appointment;

    using static CleaningWeb.Common.GlobalConstants;

    public class EmailsService : IEmailsService
    {
        public string GenerateAppointmentEmail(MakeAppointmentInputModel model)
        {
            var htmlContent = new StringBuilder();

            htmlContent.AppendLine($"<h1>{NewAppointmentMessage} {model.CreatedOn.ToShortDateString()}</h1>")
                .AppendLine("<hr>")
                .AppendLine("<h3>Information about the client:</h3>")
                .AppendLine($"<h5>Name: {model.Name}</h5>")
                .AppendLine($"<h5>Phone: {model.Phone}</h5>")
                .AppendLine("<hr>")
                .AppendLine("<h3>Appointment's Description:</h3>")
                .AppendLine($"<h5>{model.Description}</h5>");

            return htmlContent.ToString().TrimEnd();
        }
    }
}
