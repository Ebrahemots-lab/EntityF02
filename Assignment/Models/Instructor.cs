using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Instructor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Bouns { get; set; }

        public int Salray { get; set; }

        public string? Adress { get; set; }

        public int HourRate { get; set; }

        [ForeignKey("Department")]
        public int DeptId { get; set; }

        [ForeignKey("WorksFor")]
        public int WorkForDept { get; set; }    

        public Department Department { get; set; }

        public Department WorksFor { get; set; }

        ICollection<CourseInst> InctructorCourses { get; set; }

    }
}
