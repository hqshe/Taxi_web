using System.ComponentModel.DataAnnotations;

namespace Taxi_site.Models
{
    public class DriverDeal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public string? Code { get; set; }

        [Required]
        public int HigherPayment { get; set; }
    }
}
