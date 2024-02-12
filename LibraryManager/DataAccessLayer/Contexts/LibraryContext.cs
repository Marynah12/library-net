using System.Collections.Generic;
using BusinessObjects.Entity;
using Microsoft.EntityFrameworkCore;

public class LibraryContext : DbContext
{

    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Library> Libraries { get; set; }



    protected override void OnModelCreating( ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().ToTable("book");
        
    }

}