using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Ins_Id { get; set; }

        public DateTime HiringDate { get; set; }

        [InverseProperty(nameof(Instructor.Department))]
        public ICollection<Instructor> Instructors { get; set; }

        [ForeignKey("Manger")]
        public int Manger_Id { get; set; }



        public Instructor Manger { get; set; }

        public ICollection<Student> Students { get; set; }




    }
}
