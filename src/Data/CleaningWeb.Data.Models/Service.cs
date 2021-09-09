namespace CleaningWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static CleaningWeb.Common.GlobalConstants;

    public class Service
    {
        public int Id { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        [MaxLength(TitleLength.MaxTitleLength)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
