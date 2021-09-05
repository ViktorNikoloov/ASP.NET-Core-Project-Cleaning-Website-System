namespace CleaningWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using CleaningWeb.Data.Common.Models;

    using static CleaningWeb.Common.GlobalConstants;

    public class Feedback : BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(TitleLength.MaxTitleLength)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
