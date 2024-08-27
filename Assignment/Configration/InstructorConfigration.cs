using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Configration
{
    internal class InstructorConfigration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(I => I.Id);

            builder.Property(I => I.Name).IsRequired()
                                         .HasMaxLength(200);


            builder.Property(I => I.Adress).HasDefaultValue("Cairo");
        }
    }
}
