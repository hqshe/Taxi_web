using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taxi_site.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DateOfOrder { get; set; }

        [Required]
        public int Cost { get; set; }
        [Required]
        public string? StartPlace { get; set; }
        [Required]
        public string? EndPlace { get; set;}
        [Required]
        [ForeignKey("PassengerId")]
        public RegisteredPassenger RegisteredPassenger { get; set; }
        [Required]
        [ForeignKey("DriverId")]
        public RegisteredDriver RegisteredDriver { get; set; }

    }
}
