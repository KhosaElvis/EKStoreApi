using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    [Table("tblPROFILE")]
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User User { set;  get; }
        public string Image { get; set; }
        public string IDNumber { get; set; }
        public string DateOfBirth { get; set; }
    }
}
