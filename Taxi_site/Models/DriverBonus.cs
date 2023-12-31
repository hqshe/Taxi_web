using System.ComponentModel.DataAnnotations;

namespace Taxi_site.Models
{
    public class DriverBonus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Expiring { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public int FreePatrol { get; set; }
        [Required]
        public int HigherPayment { get; set; }
    }
}
