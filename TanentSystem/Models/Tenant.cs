using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TanentSystem.Models
{
    public class Tenant
    {
        [Key]
        public int TenantId { get; set; }

        [ForeignKey("HouseOwnerId")]
        public HouseOwner HouseOwner { get; set; }
        public int HouseOwnerId { get; set; }

        [Required]
        [StringLength(50)]
        public string TenantName { get; set; }

        [Required(ErrorMessage ="+91 00000 00000")]
        [StringLength(15)]
        public string MobileNo { get; set; }

        [Required]
        [StringLength(200)]
        public string PermanentAddress { get; set; }

        [Required]
        [StringLength(12)]
        public string AadhaarNo { get; set; }

        [Required]
        public int MonthlyRent { get; set; }

        [Required]
        public int Deposit { get; set; }

        [Required]
        public double CurrentUnit { get; set; }

        [Required]
        public int PerUnitRate { get; set; }


    }
}
