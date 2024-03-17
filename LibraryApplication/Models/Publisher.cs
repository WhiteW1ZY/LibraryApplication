using System.ComponentModel.DataAnnotations;

namespace LibraryApplication.Models
{
    public class Publisher
    {
        [Key]
        public int PublsherId { get; set; }
        public string PublisherName { get; set;}
    }
}
