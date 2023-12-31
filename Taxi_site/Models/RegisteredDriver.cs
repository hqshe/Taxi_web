using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taxi_site.Models
{
    public class RegisteredDriver
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? FullName { get; set; }
        [Required]
        public string? Email { get; set; }

        public double Rating { get; set; }
        [Required]
        public string? Password { get; set; }

        public string? CarInfo { get; set; }

        public string? PhoneNumber { get; set; }

        [ForeignKey("PunismentId")]
        public DriverPunishment? DriverPunishment { get; set; }

        [ForeignKey("BonusId")]
        public DriverBonus? DriverBonus { get; set; }

        [ForeignKey("DealId")]
        public DriverDeal? Deal { get; set; }
    }
}
