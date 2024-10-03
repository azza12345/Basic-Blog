namespace Basic_Blog.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public ICollection<Post>? Posts { get; set; }
    }
}
