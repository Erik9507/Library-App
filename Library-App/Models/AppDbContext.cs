using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_App.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Loan> Loans { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 1,
                Title = "Harry Potter 1",
                Author = "JK Rowling",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Examples = 5
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 2,
                Title = "Harry Potter 2",
                Author = "JK Rowling",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Examples = 6
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 3,
                Title = "The fellowship of the ring",
                Author = "JRR Tolkien",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Examples = 4
            });

            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 1, FirstName = "Erik", LastName = "Norell", EMail = "ErikNorell@gmail.com" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 2, FirstName = "Viktor", LastName = "Gunnarsson", EMail = "ViktorGunnarsson@gmail.com" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 3, FirstName = "Lukas", LastName = "Rose", EMail = "LukasRose@gmail.com" });

            modelBuilder.Entity<Loan>().HasData(new Loan { LoanId = 1, BookId = 1, CustomerId = 1, LoanDate = DateTime.Now , ReturnDate= DateTime.Now.AddDays(30) });
            modelBuilder.Entity<Loan>().HasData(new Loan { LoanId = 2, BookId = 1, CustomerId = 2, LoanDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(30) });
            modelBuilder.Entity<Loan>().HasData(new Loan { LoanId = 3, BookId = 2, CustomerId = 3, LoanDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(30) });
        }
    }
}
