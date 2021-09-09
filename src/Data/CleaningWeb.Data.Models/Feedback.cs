namespace CleaningWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Feedback
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}