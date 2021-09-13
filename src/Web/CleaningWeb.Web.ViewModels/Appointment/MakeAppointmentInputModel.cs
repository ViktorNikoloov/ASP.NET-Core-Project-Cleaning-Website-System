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
        [RegularExpression(@"^[A-Za-z]+([\ A-Za-z]+)*", ErrorMessage = "\"{0}\" must contains only letters")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        [StringLength(PhoneMaxLength, ErrorMessage = "\"{0}\" must contains exactly \"{1}\" numbers.", MinimumLength = PhoneMaxLength)]
        [RegularExpression(@"[0-9]+", ErrorMessage = "\"{0}\" must contains only numbers")]
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
