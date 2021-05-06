using Microsoft.EntityFrameworkCore;

namespace RazorTools.Data
{
    public class RazorToolContext : DbContext
    {
        public RazorToolContext (
            DbContextOptions<RazorToolContext> options)
            : base(options)
        {
        }

        public DbSet<RazorTool.Models.Tool> Tool { get; set; }
    }
}