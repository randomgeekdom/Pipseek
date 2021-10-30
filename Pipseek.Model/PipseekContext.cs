using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Pipseek.Model
{
    public class PipseekContext : IdentityDbContext
    {
        public PipseekContext(DbContextOptions<PipseekContext> options)
            : base(options)
        {
        }

        public DbSet<DailyTask> DailyTasks {  get; set; }
    }
}