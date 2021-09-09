namespace CleaningWeb.Web.ViewModels.About
{
    using System.ComponentModel.DataAnnotations;

    using CleaningWeb.Data.Models;
    using CleaningWeb.Services.Mapping;

    using static CleaningWeb.Common.DataGlobalConstants.Common;
    using static CleaningWeb.Common.DataGlobalConstants.Company;

    public class CompanyViewModel : IMapFrom<Company>
    {
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
