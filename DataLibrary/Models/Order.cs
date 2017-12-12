using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    [Table("tblORDER")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("Product")]
        public int? ProductId { get; set; }
        public Product Product { get; set; }
        public List<Delivery> Deliveries { get; set; }
        public List<Report> Reports { get; set; }
        public List<Pay> Pays { get; set; }
        public decimal DeliveryCost { get; set; }
        public string Date { get; set; }
        public decimal GrandPrice { get; set; }

    }
}
