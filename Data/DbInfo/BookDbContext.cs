using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.DbInfo
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
                .HasOne(b => b.Book)
                .WithMany(ba => ba.ListOfBookAuthors)
                .HasForeignKey(bi => bi.BookId);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(b => b.Author)
                .WithMany(ba => ba.ListOfBookAuthors)
                .HasForeignKey(bi => bi.AuthorId);
        }


        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }

    }
}
