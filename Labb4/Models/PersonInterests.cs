using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4.Models
{
    public class PersonInterests
    {
        // Kopplingstabell intresse - Person
        public int ID { get; set; }
        public Person person { get; set; }
        public int interestID { get; set; }
        public Interests interests { get; set; }
        // Prop för att lagra hemsidor för intressen
        public string webpage { get; set; }


    }
}
