using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Basic_Blog.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Department> Departments { get; set; }
    }

}
