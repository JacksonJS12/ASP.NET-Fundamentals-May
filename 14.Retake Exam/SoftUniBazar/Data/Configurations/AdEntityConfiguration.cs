namespace SoftUniBazar.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SoftUniBazar.Data.Models;
    public class AdEntityConfiguration : IEntityTypeConfiguration<Ad>
    {
        public void Configure(EntityTypeBuilder<Ad> builder)
        {
            builder.Property(a => a.Name)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(a => a.Description)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(a => a.Price)
                .IsRequired();

            builder.Property(a => a.OwnerId)
                .IsRequired();

            builder.Property(a => a.ImageUrl)
                .IsRequired();

            builder.Property(a => a.CreatedOn)
                .IsRequired()
                .HasColumnType("datetime");

            builder.HasOne(a => a.Owner)
                .WithMany()
                .HasForeignKey(a => a.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Category)
                .WithMany(c => c.Ads)
                .HasForeignKey(a => a.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}