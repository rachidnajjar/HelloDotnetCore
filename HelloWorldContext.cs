using Microsoft.EntityFrameworkCore;

namespace HelloDotnetCore
{
    public class HelloWorldContext : DbContext
    {
        private const string ConnectionString = "Data Source=HelloDotnetCore.db";

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString);
        }

    }
}