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
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {


            builder.HasKey(x => x.Id);

            builder.Property(p => p.Id)
               .IsRequired()
               .ValueGeneratedOnAdd()
               .HasDefaultValueSql("NEWID()");

            builder.Property(p => p.quantity)
               .IsRequired();


            builder.Property(p => p.AddedAt)
                .IsRequired()
                .HasColumnType("datetime2(3)");




            builder.Property(p => p.UserId)
                .IsRequired();


            builder.HasOne(p => p.UserAccount)
                .WithMany()
                .HasForeignKey(p => p.UserId);



            builder.Property(p => p.ClothesVarientId)
                .IsRequired();


            builder.HasOne(p => p.ClothesVariant)
                .WithMany()
                .HasForeignKey(p => p.ClothesVarientId);
        }
    
    }
}
