using EF02.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Configurations
{
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> std)
        {
            std.Property(s => s.FName).IsRequired();
            std.Property(s => s.Address).HasDefaultValue("Fayoum");
            //std.Property(s=>s.Age).

        }
    }
}
