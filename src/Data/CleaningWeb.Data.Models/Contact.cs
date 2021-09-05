namespace CleaningWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static CleaningWeb.Common.GlobalConstants;

    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(ContactValidation.NameLenght)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
