namespace CleaningWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using CleaningWeb.Data.Common.Models;

    using static CleaningWeb.Common.GlobalConstants;

    public class Contact : BaseDeletableModel<int>
    {
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
