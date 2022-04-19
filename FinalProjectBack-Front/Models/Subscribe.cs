using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.Models
{
    public class Subscribe
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(maximumLength: 60)]
        public string Email { get; set; } 
    }
}
