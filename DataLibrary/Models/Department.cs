using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    [Table("tblDEPARTMENT")]
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        [ForeignKey("Manager")]
        public int? ManagerId { get; set; }
        public User Manager { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
