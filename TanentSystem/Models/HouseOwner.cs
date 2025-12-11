using System.ComponentModel.DataAnnotations;

namespace TanentSystem.Models
{
    public class HouseOwner
    {
        [Key]
        public int HouseOwnerId { get; set; }

        [Required(ErrorMessage ="Owner Name required")]
        [MaxLength(200)]
        public string HouseOwnerName { get; set; }

    }
}
