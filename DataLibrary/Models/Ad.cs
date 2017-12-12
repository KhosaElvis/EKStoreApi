using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    [Table("tblAD")]
    public class Ad
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int? ProductId { get; set; }
        public Product Product { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool IsSpecial { get; set; }
    }
}
