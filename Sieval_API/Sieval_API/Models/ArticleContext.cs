using Microsoft.EntityFrameworkCore;

namespace Sieval_API.Models
{
    public class ArticleContext : DbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> options)
            : base(options)
        {
        }

        public DbSet<Article> Article { get; set; } = null!;
    }
}
