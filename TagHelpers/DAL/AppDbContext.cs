using Microsoft.EntityFrameworkCore;
namespace TagHelpers.DAL
{
    public class AppDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=ALI\\SQLEXPRESS;database=BizLand, Trusted_connection=true;encrypt=false ");
            


        }

    }
}
