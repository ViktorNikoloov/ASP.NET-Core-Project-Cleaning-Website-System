namespace CleaningWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static CleaningWeb.Common.DataGlobalConstants.Feedback;

    public class Feedback
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
