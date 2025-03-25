using Microsoft.EntityFrameworkCore;
using CRUD_APP_for_test.Models;
namespace CRUD_APP_for_test.Data

{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProductDto> Products { get; set; }
        public DbSet<CategoryDto> Categories { get; set; }
    }
}
