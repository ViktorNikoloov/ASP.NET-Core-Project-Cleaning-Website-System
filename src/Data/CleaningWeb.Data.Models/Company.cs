namespace CleaningWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static CleaningWeb.Common.DataGlobalConstants.Common;
    using static CleaningWeb.Common.DataGlobalConstants.Company;

    public class Company
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(AddressMaxLength)]
        public string Address { get; set; }

        [Required]
        [MaxLength(PhoneMaxLength)]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        [Range(RangeStartedPoint, MaxYearOfExperienced)]
        public int YearOfExperienced { get; set; }

        [Range(RangeStartedPoint, IntMaxValue)]
        [Required]
        public int HappyCustomer { get; set; }

        [Required]
        [Range(RangeStartedPoint, IntMaxValue)]
        public int BuildingCleaned { get; set; }
    }
}
