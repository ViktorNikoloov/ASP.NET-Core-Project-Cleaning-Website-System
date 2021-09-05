namespace CleaningWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(11)]
        public string Phone { get; set; }

        public int ServiceId { get; set; }

        public Service Service { get; set; }
    }
}
