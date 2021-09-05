namespace CleaningWeb.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using CleaningWeb.Data.Models.Enum;

    public class Business
    {
        public int Id { get; set; }

        [Required]
        public DaysOfWeek StartDay { get; set; }

        [Required]
        public DaysOfWeek EndDay { get; set; }

        [Required]
        public DateTime StartHour { get; set; }

        [Required]
        public DateTime EndHour { get; set; }

        [Required]
        [MaxLength(11)]
        public string EmergencyPhone { get; set; }

        public IEnumerator<string> Vacations { get; set; }
    }
}
