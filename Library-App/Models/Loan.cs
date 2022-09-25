using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library_App.Models
{
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
        public int BookId { get; set; }
        public Book book { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
