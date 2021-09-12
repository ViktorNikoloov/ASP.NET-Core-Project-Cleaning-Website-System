namespace CleaningWeb.Services.Data.Contact
{
    using CleaningWeb.Web.ViewModels;
    using System.Threading.Tasks;

    public interface IContactService
    {
        Task<bool> CreateContactFromCustomer(ContactFormModel contactFormModel);
    }
}
