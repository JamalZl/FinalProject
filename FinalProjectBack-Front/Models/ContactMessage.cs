using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.Models
{
    public class ContactMessage
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter a message")]
        [StringLength(maximumLength: 500)]
        public string Message { get; set; }
        [Required(ErrorMessage = "Please enter a fullname")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Please enter a email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter a number")]
        public string Number { get; set; }
        public DateTime SendDate { get; set; }
    }
}
