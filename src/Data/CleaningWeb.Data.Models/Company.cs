namespace CleaningWeb.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Company
    {
        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [MaxLength(11)]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [Range(0, 200)]
        public int YearOfExperienced { get; set; }

        [Range(0, int.MaxValue)]
        [Required]
        public int HappyCustomer { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int BuildingCleaned { get; set; }
    }
}
