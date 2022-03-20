using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4.Models
{
    public class Interests
    {
        [Key]
        public int interestID { get; set; }
        public string Name { get; set; }
        public string details { get; set; }
    }
}
