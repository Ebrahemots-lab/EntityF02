using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class CourseInst
    {
        [Key]
        public int Ins_Id { get; set; }

        public int Course_Id { get; set; }

        public string Evaluate { get; set; }

    }
}
