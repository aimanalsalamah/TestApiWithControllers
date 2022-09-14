using Microsoft.EntityFrameworkCore;

namespace TestApiWithControllers.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext (DbContextOptions<ApiContext> options)
            : base(options)
        {
            if (!this.Database.CanConnect())
                this.Database.EnsureCreated();
        }

        public DbSet<TestApiWithControllers.Models.News> News { get; set; } = default!;
    }
}
