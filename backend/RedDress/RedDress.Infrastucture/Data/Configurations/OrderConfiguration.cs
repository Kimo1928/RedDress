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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Id)
               .IsRequired()
               .ValueGeneratedOnAdd()
               .HasDefaultValueSql("NEWID()");


            builder.Property(p => p.OrderDate)
                .IsRequired()
                .HasColumnType("datetime2(3)");


            builder.Property(p => p.Status)
                .IsRequired()
                .HasMaxLength(100);





            builder.Property(p => p.TotalAmount)
                .IsRequired()
                .HasColumnType("decimal(6,2)");


            builder.Property(p => p.UserId)
                .IsRequired();


            builder.HasOne(p => p.UserAccount)
                .WithMany()
                .HasForeignKey(p => p.UserId);
        }
    }
}
