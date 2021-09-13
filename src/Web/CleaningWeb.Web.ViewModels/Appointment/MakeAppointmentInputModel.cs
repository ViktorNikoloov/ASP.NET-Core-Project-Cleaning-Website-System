namespace CleaningWeb.Web.ViewModels.Appointment
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static CleaningWeb.Common.DataGlobalConstants.Appointment;
    using static CleaningWeb.Common.DataGlobalConstants.Common;

    public class MakeAppointmentInputModel
    {
        [Required]
        [StringLength(NameMaxLength, ErrorMessage = "\"{0}\" must be between \"{2}\" and \"{1}\" letters.", MinimumLength = NameMinLength)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        [StringLength(PhoneMaxLength, ErrorMessage = "\"{0}\" must contains exactly \"{1}\" numbers.", MinimumLength = PhoneMaxLength)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [StringLength(DescriptionMaxLength, ErrorMessage = "\"{0}\" must be between \"{2}\" and \"{1}\" symbols.", MinimumLength = DescriptionMinLength)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; }
    }
}
