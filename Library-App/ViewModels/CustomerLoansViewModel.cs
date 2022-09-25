using Library_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_App.ViewModels
{
    public class CustomerLoansViewModel
    {
        public Customer customer { get; set; }
        public IEnumerable<Loan> loans { get; set; }
    }
}
