namespace CleaningWeb.Web.Controllers
{
    using System.Threading.Tasks;

    using CleaningWeb.Services.Data.Contact;
    using CleaningWeb.Web.ViewModels;
    using Microsoft.AspNetCore.Mvc;

    public class ContactController : BaseController
    {
        private readonly IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ContactFormModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.contactService.CreateContactFromCustomer(model);

            return this.RedirectToAction("Index", "Home");
        }
    }
}
