using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Wagner.Data
{
    public class ProjectsContextFactory : IDesignTimeDbContextFactory<ProjectsContext>
    {
        public IConfiguration Configuration { get; set; }

        public ProjectsContextFactory()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }

        public ProjectsContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProjectsContext>();
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            return new ProjectsContext(optionsBuilder.Options);
        }
    }
}