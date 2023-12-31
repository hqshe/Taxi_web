using System.ComponentModel.DataAnnotations;

namespace Taxi_site.Models
{
    public class PassengerPunishment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Explanation { get; set; }
        [Required]
        public double ExitRate { get; set; }
        [Required]
        public int HigherPayment { get; set; }
    }
}
