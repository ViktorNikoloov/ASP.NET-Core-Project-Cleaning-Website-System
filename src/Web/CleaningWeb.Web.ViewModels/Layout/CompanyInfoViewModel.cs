namespace CleaningWeb.Web.ViewModels.Layout
{
    using System.ComponentModel.DataAnnotations;

    using CleaningWeb.Data.Models;
    using CleaningWeb.Services.Mapping;

    using static CleaningWeb.Common.DataGlobalConstants.Common;
    using static CleaningWeb.Common.DataGlobalConstants.Company;

    public class CompanyInfoViewModel : IMapFrom<Company>
    {
        private const string Code = "(+1)";

        [Required]
        [MaxLength(AddressMaxLength)]
        public string Address { get; set; }

        [Required]
        [MaxLength(PhoneMaxLength)]
        public string Phone { get; set; }

        public string PhoneNumber => $"{Code} {this.Phone}";

        [Required]
        public string Email { get; set; }
    }
}
