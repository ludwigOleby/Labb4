using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNr { get; set; }
        // One-to-many
        public ICollection<Interests> interests { get; set; }
    }
}
