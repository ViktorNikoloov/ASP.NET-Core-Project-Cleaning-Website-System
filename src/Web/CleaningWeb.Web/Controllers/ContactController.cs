namespace CleaningWeb.Web.Controllers
{
    using CleaningWeb.Services.Data.Contact;
    using CleaningWeb.Web.ViewModels;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class ContactController : BaseController
    {
        private readonly IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }

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

            return this.View();
        }
    }
}
