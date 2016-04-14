using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestMvcApplication.Models
{
    public class Employee
    {
        [Required]
        [Key]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
    }
}