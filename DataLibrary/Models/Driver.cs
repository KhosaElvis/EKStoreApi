using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    [Table("tblDRIVER")]
    public class Driver
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Employee")]
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public List<Delivery> Deliveries { get; set; }
        public string LicenseNumber { get; set; }
        public string LicenseType { get; set; }
    }
}
