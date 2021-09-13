namespace CleaningWeb.Web.Controllers
{
    using CleaningWeb.Services.Data.Appointment;
    using CleaningWeb.Web.ViewModels.Appointment;

    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class AppointmentController : BaseController
    {
        private readonly IAppointmentsService appointmentService;

        public AppointmentController(IAppointmentsService appointmentService)
        {
            this.appointmentService = appointmentService;
        }

        [HttpPost]
        public async Task<IActionResult> MakeAppointment(MakeAppointmentInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            await this.appointmentService.MakeAppointmentAsync(model);

            this.TempData["Message"] = $"Your appointment was sent successfully";

            return this.Redirect("/");
        }
    }
}
