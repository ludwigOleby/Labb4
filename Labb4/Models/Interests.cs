using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Labb4.Models
{
    public class Interests
    {
        [Key]
        public int interestID { get; set; }
        public string interestName { get; set; }
        public string details { get; set; }

     
        public Person Person { get; set; }
        public int PersonID { get; set; }

        public ICollection<Websites> websites { get; set; }
    }
}
