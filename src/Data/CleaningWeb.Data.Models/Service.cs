namespace CleaningWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;
     
    public class Service
    {
        public int Id { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}