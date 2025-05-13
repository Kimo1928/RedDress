using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedDress.Core.Entities;

namespace RedDress.Infrastucture.Data.Configurations
{
    public class ClothesVariantConfiguration : IEntityTypeConfiguration<ClothesVariant>
    {
        public void Configure(EntityTypeBuilder<ClothesVariant> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("NEWID()");

            builder.Property(x => x.ClothesId)
                .IsRequired();

            builder.Property(x => x.ClothesColorId)
                .IsRequired();

            builder.Property(x => x.ClothesSizeId)
                .IsRequired();

            builder.Property(x => x.PhotoId)
                .IsRequired();

            builder.Property(x => x.PricePerUnit)
                .IsRequired()
                .HasColumnType("decimal(6,2)");

            builder.Property(x => x.stock)
                .IsRequired();

         
            builder.HasOne(x => x.ClothesColor)
                .WithMany()
                .HasForeignKey(x => x.ClothesColorId);

            builder.HasOne(x => x.ClothesSize)
                .WithMany()
                .HasForeignKey(x => x.ClothesSizeId);

            builder.HasOne(x => x.Photo)
                .WithMany()
                .HasForeignKey(x => x.PhotoId);
        }
    }
}
