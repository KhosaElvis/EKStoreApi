using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    [Table("tblSUBSCRIPTION")]
    public class Subscription
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("NewsLetter")]
        public int NewsLetterId { get; set; }
        public NewsLetter NewsLetter { get; set; }

    }
}
