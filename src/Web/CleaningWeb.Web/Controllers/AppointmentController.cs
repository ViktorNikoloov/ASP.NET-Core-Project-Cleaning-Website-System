namespace CleaningWeb.Web.Controllers
{
    using CleaningWeb.Web.ViewModels.Appointment;

    using Microsoft.AspNetCore.Mvc;

    public class AppointmentController : BaseController
    {
        [HttpPost]
        public IActionResult MakeAppointment(MakeAppointmentInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            this.TempData["Message"] = $"Your appointment was sent successfully";

            return this.Redirect("/");
        }
    }
}
