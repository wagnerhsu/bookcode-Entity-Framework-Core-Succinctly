using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wagner.Domain;

namespace Wagner.Data
{
    public class ProjectEntityTypeConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
              .HasOne(x => x.Customer)
              .WithMany(x => x.Projects)
              .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
