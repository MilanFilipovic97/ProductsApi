using Microsoft.EntityFrameworkCore;
using ProductsApiExtended.Models;

namespace ProductsApiExtended.DbContexts
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options): base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<StudentAdress> StudentAddresses { get; set; } = null!;
        public DbSet<Pupil> Pupils { get; set; } = null!;
        public DbSet<Grade> Grades { get; set; } = null!;
        public DbSet<Course> Courses { get; set; } = null!;

    }
}
