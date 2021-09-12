namespace CleaningWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static CleaningWeb.Common.DataGlobalConstants.Service;

    public class Service
    {
        public int Id { get; set; }

        public string Image { get; set; }

        [Required]
        [MaxLength(TitleLength)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
