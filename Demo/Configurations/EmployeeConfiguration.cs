using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(E => E.Id);
            builder.Property(E => E.Id).UseIdentityColumn(10, 10);
            builder.Property(E => E.Name)
                   .HasColumnName("EmployeeName")
                   .HasColumnType("varchar")
                   .HasMaxLength(50)
                                           .IsRequired();
            builder.Property(E => E.Salary)
                                   .HasColumnType("decimal(18,2)")
                                   .IsRequired(false);
        }
    }
}
