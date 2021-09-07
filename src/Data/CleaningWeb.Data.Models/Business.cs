namespace CleaningWeb.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using CleaningWeb.Data.Models.Enum;

    using static CleaningWeb.Common.DataGlobalConstants.Business;
    using static CleaningWeb.Common.DataGlobalConstants.Common;

    public class Business
    {
        public Business()
        {
            this.Vacations = new HashSet<Vacation>();
        }

        public int Id { get; set; }

        [Required]
        public DaysOfWeek StartDay { get; set; }

        [Required]
        public DaysOfWeek EndDay { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime StartHour { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime EndHour { get; set; }

        [Required]
        [MaxLength(PhoneMaxLength)]
        public string EmergencyPhone { get; set; }

        [Range(RangeStartedPoint, MaxVacations)]
        public virtual ICollection<Vacation> Vacations { get; set; }
    }
}
