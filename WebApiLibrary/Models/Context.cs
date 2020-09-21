using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiLibrary.Models
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public Context(DbContextOptions options) : base(options)
        { }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    builder.Entity<Book>().HasMany<Borrow>(g => g.Borrows).WithOne(p => p.Book).HasForeignKey(s => s.BookId);
        //    builder.Entity<User>().HasMany<Borrow>(g => g.Borrows).WithOne(p => p.User).HasForeignKey(s => s.UserId);
        //    //builder.Entity<Borrow>().ToTable("Borrows");
        //    //builder.Entity<Book>().ToTable("Books");
        //    //builder.Entity<User>().ToTable("Users");
        //}
    }
}
