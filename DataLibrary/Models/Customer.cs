using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    [Table("tblCUSTOMER")]
    public class Customer
    {     
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User User { get; set; }
        public string DateSignUp { get; set; }
        public List<Delivery> Deliveries { get; set; }
        public List<Order> Orders { get; set; }
        public List<GpsLoation> GpsLocations { get; set; }
        public List<Pay> Pays { get; set; }
        public string LastTimeLoggedIn { get; set; }
    }
}
