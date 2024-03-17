using System.ComponentModel.DataAnnotations;

namespace Library.Core.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password {  get; set; }
    }
}
