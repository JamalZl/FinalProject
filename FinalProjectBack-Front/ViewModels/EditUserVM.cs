using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBack_Front.ViewModels
{
    public class EditUserVM
    {
        [StringLength(maximumLength: 30)]
        public string Username { get; set; }
        [StringLength(maximumLength: 70)]
        public string Email { get; set; }

        [StringLength(maximumLength: 30)]
        public string Name { get; set; }

        [StringLength(maximumLength: 30)]
        public string Surname { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string TelephoneNumber { get; set; }
        public int Age { get; set; }
    }
}
