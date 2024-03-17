
using System.ComponentModel.DataAnnotations;

namespace LibraryApplication.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string GenreName { get; set; }
    }
}
