using System.ComponentModel.DataAnnotations;

namespace LibraryApplication.Models
{
    public class Reader
    {
        [Key]
        public int ReaderId { get; set; }

        public string ReaderName { get; set; }
        public string ReaderSurname { get; set; }

        public string ReaderPassportNumber { get; set; }

        public List<Book> StoredBooks { get; set; } = new List<Book>();
    }
}
