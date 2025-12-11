using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [MaxLength(200)]
        [Required(ErrorMessage = "Product name sahi se dale")]
        public string ProductName { get; set; }

        [MaxLength(20)]        
        public string Weight { get; set; }

        [Required(ErrorMessage = "required mrp")]
        public double? MRP { get; set; }

        [Required(ErrorMessage = "required rate")]
        public double? Rate { get; set; }

        [Required(ErrorMessage = "required gst")]
        public double? GST { get; set; }
    }
}
