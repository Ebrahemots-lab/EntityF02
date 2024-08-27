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
    internal class Course_InsConfigration : IEntityTypeConfiguration<CourseInst>
    {
        public void Configure(EntityTypeBuilder<CourseInst> builder)
        {
            builder.HasKey(C => C.Ins_Id);

            builder.Property(C => C.Course_Id).IsRequired();
        }
    }
}
