using Microsoft.EntityFrameworkCore;

namespace CRUDMVC.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
