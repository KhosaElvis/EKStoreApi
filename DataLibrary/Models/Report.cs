using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    [Table("tblREPORT")]
    public class Report
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Order")]
        public int? OrderId { get; set; }
        public Order Order { get; set; }
        public string SalesYear { get; set; }
        public string SalesDateFrom { get; set; }
        public string SalesDateTo { get; set; }
    }
}
