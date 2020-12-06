using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5.Models
{
    public class Software
    {
        //getters and setters for the program

        //software id 
        public int softwareID { get; set; }
        //software manufacture 
        public string make { get; set; }
        //software version
        public string model { get; set; }
        //software year it was purchased
        public int year { get; set; }
        //software price 
        public int price { get; set; }
    }
}
