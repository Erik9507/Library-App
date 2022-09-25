using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library_App.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2,
        ErrorMessage = "* Part descriptions must be between 2 and 25 characters in length.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2,
        ErrorMessage = "* Part descriptions must be between 2 and 25 characters in length.")]
        public string LastName { get; set; }

        [Required]
        public string EMail { get; set; }
    }
}
