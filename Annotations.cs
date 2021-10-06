using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotations
{
    public class Author
    {
        [Required(ErrorMessage = "Please enter {0}")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "First Name should be minimum 3 haracters and a miximum of 50 caharcters")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Last Name should be minimum 3 haracters and a miximum of 50 caharcters")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        [StringLength(10, MinimumLength = 10,
            ErrorMessage = "Phone number should be exactly 10 numbers")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

    }
}