using Library.Core.Models;
using LibraryApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Application.Db
{
    public class LibraryContext: DbContext
    {
        public LibraryContext()
        {
            Database.EnsureCreated();
        }
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=applicationdb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData
                (
                    new User { UserId = 1, Name = "admin", Password = "admin" },
                    new User { UserId = 2, Name = "Kanash", Password = "P42" },
                    new User { UserId = 3, Name = "", Password = ""}
                );

            modelBuilder.Entity<Genre>().HasData
                (
                    new Genre { GenreId = 1, GenreName = "Роман"},
                    new Genre { GenreId = 2, GenreName = "Художественная литература"},
                    new Genre { GenreId = 3, GenreName = "Басня"}
                );

            modelBuilder.Entity<Publisher>().HasData
                (
                    new Publisher { PublsherId = 1, PublisherName = "БЕЛСТАН" },
                    new Publisher { PublsherId = 2, PublisherName = "БиРинг" },
                    new Publisher { PublsherId = 3, PublisherName = "РэйПлац" }
                );
            modelBuilder.Entity<Book>().HasData
                (
                    new Book
                    {
                        BookId = 1,
                        Author = "Джордж Оруэлл",
                        Title = "1984",
                        BookCount = 1000,
                        genres = new List<Genre>(),
                        publishers = new List<Publisher>(),
                        YearOfPublish = 1949,
                        readers = new List<Reader>()
                    },
                     new Book
                     {
                         BookId = 2,
                         Author = "Михаил Булгаков",
                         Title = "Мастер и Маргарита",
                         BookCount = 10,
                         genres = new List<Genre>(),
                         publishers = new List<Publisher>(),
                         YearOfPublish = 1967,
                         readers = new List<Reader>()
                     }
                ) ;
            modelBuilder.Entity<Reader>().HasData
                (
                    new Reader { ReaderId = 1, ReaderName = "Валентин", ReaderSurname = "Михайлов", ReaderPassportNumber = "HB1234567989" },
                    new Reader { ReaderId = 2, ReaderName = "Михаил",ReaderSurname = "Стрыкало", ReaderPassportNumber = "HB987654321" },
                    new Reader { ReaderId = 3, ReaderName = "Григорий", ReaderSurname = "Лепс", ReaderPassportNumber = "HB192837465" }
                );
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Genre> Genres {  get; set; } = null!;
        public DbSet<Publisher> Publishers { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Reader> Readers { get; set; } = null!;
    }
}
