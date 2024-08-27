using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class StudCourse
    {
        [Key]
        public int Stud_Id { get; set; }

        public int Course_Id { get; set; }

        public int Grade { get; set; }


    }
}
