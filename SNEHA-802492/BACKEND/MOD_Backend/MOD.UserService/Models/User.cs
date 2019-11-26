using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.UserService.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Uid { get; set; }
     
        public string Uname { get; set; }
        
        public string Umail { get; set; }
     
        public long Unumber { get; set; }
    
        public string Upassword { get; set; }
        public bool Uactive { get; set; }
    public IEnumerable<Training> Training { get; set; }
    public IEnumerable<Payment> Payment{ get; set; }
  }
}
