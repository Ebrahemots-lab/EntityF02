using Assignment.Configration;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Context
{
    internal class ItiEnterprise : DbContext
    {


        //Fluent Api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseConfigration());
            modelBuilder.ApplyConfiguration(new Course_InsConfigration());
            modelBuilder.ApplyConfiguration(new DepartmentConfigration());
            modelBuilder.ApplyConfiguration(new InstructorConfigration());
            modelBuilder.ApplyConfiguration(new StudentConfigration());
            modelBuilder.ApplyConfiguration(new Stud_CourseConfigration());
            modelBuilder.ApplyConfiguration(new TopicConfigration());
            base.OnModelCreating(modelBuilder);
        }




        //Convention Way
        //Instantiate Connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server = . ; Database = ItiEnterprise; Trusted_Connection = true");
        }


        //Convention
        public DbSet<Student> Students { get; set; }

        public DbSet<StudCourse> Student_Course { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<CourseInst> Course_Inst { get; set; }

        public DbSet<Instructor> instructors { get; set; }



    }
}
