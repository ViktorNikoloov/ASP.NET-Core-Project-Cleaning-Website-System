namespace CleaningWeb.Services.Data.Contact
{
    using System;
    using System.Threading.Tasks;

    using CleaningWeb.Data.Common.Repositories;
    using CleaningWeb.Data.Models;
    using CleaningWeb.Web.ViewModels;

    public class ContactService : IContactService
    {
        private readonly IRepository<Contact> contactRepository;

        public ContactService(IRepository<Contact> contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        public async Task<bool> CreateContactFromCustomer(ContactFormModel contactFormModel)
        {
            var newContact = new Contact
            {
                Name = contactFormModel.FullName,
                Email = contactFormModel.Email,
                Subject = contactFormModel.Subject,
                Message = contactFormModel.Messages,
                CreatedOn = DateTime.UtcNow,
            };

            if (newContact == null)
            {
                return false;
            }

            await this.contactRepository.AddAsync(newContact);
            await this.contactRepository.SaveChangesAsync();
            return true;
        }
    }
}
