using System.ComponentModel.DataAnnotations;
namespace Taxi_site.Models
{
    public class PassengerBonus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Expiring { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public int FreeOrders { get; set; }
        [Required]
        public int Discount { get; set; }

    }
}
