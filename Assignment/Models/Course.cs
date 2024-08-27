using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Course
    {
        public int Id { get; set; }

        public int? Duration { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        [ForeignKey("Topic")]
        public int TopicId { get; set; }

        public Topic Topic { get; set; }

        public ICollection<StudCourse> studCourses { get; set; }

        public ICollection<CourseInst> courseInsts { get; set; }
    }
}
