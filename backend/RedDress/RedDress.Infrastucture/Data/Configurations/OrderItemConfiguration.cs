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
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(x => x.Id);


            builder.Property(p => p.Id)
               .IsRequired()
               .ValueGeneratedOnAdd()
               .HasDefaultValueSql("NEWID()");



            builder.Property(p => p.quantity)
                .IsRequired();
                


            builder.Property(p => p.ClothesVarientId)
                .IsRequired();


            builder.HasOne(p => p.ClothesVariant)
                .WithMany()
                .HasForeignKey(p => p.ClothesVarientId);

            builder.Property(p => p.OrderId)
                .IsRequired();


            builder.HasOne(p => p.Order)
                .WithMany()
                .HasForeignKey(p => p.OrderId);
        }

    }
    
}
