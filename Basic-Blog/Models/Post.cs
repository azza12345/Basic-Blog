namespace Basic_Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string PostType { get; set; }
        public string Title { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
