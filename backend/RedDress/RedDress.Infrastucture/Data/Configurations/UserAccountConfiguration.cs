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
    public class UserAccountConfiguration : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired();



            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(100);


            builder.Property(x => x.BirthDate)
                .IsRequired()
                .HasColumnType("datetime2(3)");


            builder.Property(x => x.RoleId)
                .IsRequired();


            builder.HasOne(x => x.Role)
                .WithMany()
                .HasForeignKey(x => x.RoleId);
        
        }





                

        }
    }

