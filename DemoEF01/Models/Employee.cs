using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF01.Models
{
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Fname { get; set; }

        public string? Lname { get; set; }

        [Range(20,60)]
        public int Age { get; set; }

        [Column(TypeName = "money")]
        public decimal salary { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
