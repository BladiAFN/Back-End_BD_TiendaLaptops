using Microsoft.EntityFrameworkCore;
using WebApi.Entidades;

namespace WebApi.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Laptop> Laptops {  get; set; }
 
       
    }
}
