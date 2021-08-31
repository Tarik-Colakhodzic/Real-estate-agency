using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RealEstateAgency.Model.Requests
{
    public class UserInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }
        [EmailAddress()]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Username { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Password { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string ConfirmedPassword { get; set; }
        //public bool? Status { get; set; }
        //public List<int> Roles { get; set; } = new List<int>();
    }
}
