using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    [Table("tblEMPLOYEE")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<Driver> Drivers { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User User { get; set; }
        public int Age { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string EmployeeNumber { get; set; }
        public string HighestQualification { get; set; }
    }
}
