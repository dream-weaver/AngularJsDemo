using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public Flight Flight { get; set; }
        public int FlightID { get; set; }
    }
}
