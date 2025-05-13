using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedDress.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedDress.Infrastucture.Data.Configurations
{
    public class ClothesConfiguration : IEntityTypeConfiguration<Clothes>
    {

        public void Configure(EntityTypeBuilder<Clothes> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Id)
               .IsRequired()
               .ValueGeneratedOnAdd()
               .HasDefaultValueSql("NEWID()");


            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);



            builder.Property(p=>p.Description)
                .IsRequired()
                .HasMaxLength(200);



            builder.Property(p => p.JoinedAt)
                .IsRequired()
                .HasColumnType("datetime2(3)");


            builder.Property(p => p.ClothesTypeId)
                .IsRequired();


            builder.HasOne(p => p.ClothesType)
                .WithMany()
                .HasForeignKey(p => p.ClothesTypeId);


        }
    }
}
