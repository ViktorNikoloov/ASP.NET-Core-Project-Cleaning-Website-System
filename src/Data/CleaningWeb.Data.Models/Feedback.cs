namespace CleaningWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using CleaningWeb.Data.Common.Models;

    using static CleaningWeb.Common.GlobalConstants;

    public class Feedback
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(TitleLength.MaxTitleLength)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
