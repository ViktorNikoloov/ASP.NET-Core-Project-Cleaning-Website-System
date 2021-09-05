namespace CleaningWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using CleaningWeb.Data.Common.Models;

    using static CleaningWeb.Common.GlobalConstants;

    public class Service : BaseDeletableModel<int>
    {
        [Required]
        public string Image { get; set; }

        [Required]
        [MaxLength(TitleLength.MaxTitleLength)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
