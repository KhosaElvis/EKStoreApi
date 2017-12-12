using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    [Table("tblGPSLOCATION")]
    public class GpsLoation
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public List<Delivery> Deliveries { get; set; }
    }
}
