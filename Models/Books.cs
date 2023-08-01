using System.ComponentModel.DataAnnotations;

namespace IdentityProject.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
