namespace CleaningWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static CleaningWeb.Common.DataGlobalConstants.Appointment;
    using static CleaningWeb.Common.DataGlobalConstants.Common;

    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(PhoneMaxLength)]
        public string Phone { get; set; }

        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }
    }
}
