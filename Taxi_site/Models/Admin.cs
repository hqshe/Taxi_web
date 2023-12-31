using System;
using System.ComponentModel.DataAnnotations;

namespace Taxi_site.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string?  FullName { get; set; }

        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Email { get; set; }
    }
}
