namespace CleaningWeb.Web.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    using static CleaningWeb.Common.GlobalConstants;

    public class ContactFormModel
    {
        [Display(Name = ContactFormData.FullName)]
        [Required]
        public string FullName { get; set; }

        [Display(Name = ContactFormData.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = ContactFormData.LenghtMessage)]
        public string Messages { get; set; }
    }
}
