namespace CleaningWeb.Web.Controllers
{

    using System;
    using System.Threading.Tasks;
   
    using CleaningWeb.Common;
    using CleaningWeb.Services.Data.Appointment;
    using CleaningWeb.Services.Data.Email;
    using CleaningWeb.Services.Messaging;
    using CleaningWeb.Web.ViewModels.Appointment;

    using Microsoft.AspNetCore.Mvc;

    public class AppointmentController : BaseController
    {
        private readonly IAppointmentsService appointmentService;
        private readonly IEmailsService emailsService;
        private readonly IEmailSender emailSender;

        public AppointmentController(
            IAppointmentsService appointmentService,
            IEmailsService emailsService,
            IEmailSender emailSender)
        {
            this.appointmentService = appointmentService;
            this.emailsService = emailsService;
            this.emailSender = emailSender;
        }
        
        [HttpPost]
        public IActionResult MakeAppointment(MakeAppointmentInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var isSuccessful = await this.appointmentService.MakeAppointmentAsync(model);

            if (!isSuccessful)
            {
                return this.Redirect("/Shared/Error");
            }

            model.CreatedOn = DateTime.UtcNow.ToLocalTime();
            var content = this.emailsService.GenerateAppointmentEmail(model);
            var title = "New Appointment";

            await this.emailSender.SendEmailAsync(
                GlobalConstants.SystemEmail, // Need to put the email which is Sendgrid Verified !
                model.Name,
                GlobalConstants.SystemEmail, // Put the email on which you want to receive the messages.
                title,
                content);

            this.TempData["Message"] = $"Your appointment was sent successfully";

            return this.Redirect("/");
        }
    }
}
