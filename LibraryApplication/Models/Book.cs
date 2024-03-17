using System.ComponentModel.DataAnnotations;

namespace LibraryApplication.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }

        public int YearOfPublish { get; set; }
        public int BookCount { get; set; }

        public List<Genre> genres { get; set; } = new List<Genre>();
        public List<Publisher> publishers { get; set; } = new List<Publisher>();

        public List<Reader> readers { get; set; } = new List<Reader>();
    }
}
