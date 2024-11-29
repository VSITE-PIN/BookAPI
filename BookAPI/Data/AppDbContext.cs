using BookAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BooksAuthors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) :
       base(options)
        { }
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BookAuthor>()
            .HasOne(b => b.Book)
            .WithMany(ba => ba.BookAuthors)
            .HasForeignKey(bi => bi.BookId);
            modelBuilder.Entity<BookAuthor>()
            .HasOne(b => b.Author)
            .WithMany(ba => ba.BookAuthors)
            .HasForeignKey(bi => bi.AuthorId);
        }
    }
}