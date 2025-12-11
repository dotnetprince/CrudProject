using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace TanentSystem.Models
{
    public class Rent
    {

        [Key]
        public int RentId { get; set; }

        [Required]
        public DateTime RentedOn { get; set; }

        [Required]
        public double EbillUnit { get; set; }

        [Required]
        public int CurrentRentAmount { get; set; }

        [Required]
        public DateTime RentMonth { get; set; }
    }
}
