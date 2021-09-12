namespace CleaningWeb.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static CleaningWeb.Common.DataGlobalConstants.Contact;

    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(ContactValidation)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
