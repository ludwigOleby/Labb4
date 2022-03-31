using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4.Models
{
    public class Websites
    {
        //Websites
        [Key]
        public int WebpageID { get; set; }
        public string Webpage { get; set; }
        public Interests interests { get; set; }
        public int InterestID { get; set; }
        public Person persons { get; set; }
        public int PersonID { get; set; }
        

    }
}
