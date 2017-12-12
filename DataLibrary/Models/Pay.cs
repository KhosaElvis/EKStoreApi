using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    [Table("tblPAY")]
    public class Pay
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Order")]
        public int? OrderId { get; set; }
        public Order Order { get; set; }
        [ForeignKey("Delivery")]
        public int? DeliveryId { get; set; }
        public Delivery Delivery { get; set; }
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Date { get; set; }
        public decimal Payed { get; set; }
    }
}
