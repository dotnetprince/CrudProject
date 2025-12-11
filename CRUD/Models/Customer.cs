using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [MaxLength(200)]
        [Required(ErrorMessage = "Please enter name")]
        [Display(Name = "Customer Name", Prompt = "Please enter customer name")]
        public string CustomerName { get; set; }

        [MaxLength(15)]
        [Display(Name = "Gender", Prompt = "Please enter your gender")]
        public string Gender { get; set; }

        [MaxLength(15)]
        [Required(ErrorMessage = "Please enter mobile no")]
        [Display(Name = "Mobile No", Prompt = "+91 00000 00000")]
        public string MobileNo { get; set; }

        [MaxLength(100)]
        [Display(Name = "Email Address", Prompt = "youremail@example.com")]
        public string EmailId { get; set; }

        [MaxLength(500)]
        [Display(Name = "Address", Prompt = "Type here...")]
        public string Address { get; set; }

    }
}
