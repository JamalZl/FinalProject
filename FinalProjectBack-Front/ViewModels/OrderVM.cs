using FinalProjectBack_Front.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.ViewModels
{
    public class OrderVM
    {
        [Required]
        [StringLength(maximumLength: 20)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 25)]
        public string Surname { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string Address { get; set; }
        [Required]
        [StringLength(maximumLength: 40)]
        public string Country { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string State { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public List<BasketItem> BasketItems { get; set; }
    }
}
