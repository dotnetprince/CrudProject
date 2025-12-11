using System.ComponentModel.DataAnnotations;

namespace TanentSystem.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }

        [Required]
        public string HomeDescription { get; set; }

    }
}
