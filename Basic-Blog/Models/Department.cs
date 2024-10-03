using System.ComponentModel.DataAnnotations;

namespace Basic_Blog.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Range(2000, 2024, ErrorMessage = "Create date must be between 2000 and 2024.")]
        public int CreateDate { get; set; }

        public ICollection<Author> Authors { get; set; }
    }
}
