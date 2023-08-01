using IdentityProject.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityProject.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }
        // This is where we will be adding the Models
        DbSet<Books> books { get; set; }
    }
}
