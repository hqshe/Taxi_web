using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taxi_site.Models
{
    public class RegisteredPassenger
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? FullName { get; set; }
        public double Rating { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
        [ForeignKey("PunishmentId")]
        public PassengerPunishment? PassengerPunishment { get; set; }
        [ForeignKey("BonusId")]
        public PassengerBonus? PassengerBonus { get; set; }
        [ForeignKey("DealId")]
        public PassengerDeal? Deal { get; set; }
    }
}
