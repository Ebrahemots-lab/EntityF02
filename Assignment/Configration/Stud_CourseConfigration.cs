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
    internal class Stud_CourseConfigration : IEntityTypeConfiguration<StudCourse>
    {
        public void Configure(EntityTypeBuilder<StudCourse> builder)
        {
            builder.HasKey(S => S.Stud_Id);

            builder.Property(S => S.Grade).IsRequired();





        }
    }
}
