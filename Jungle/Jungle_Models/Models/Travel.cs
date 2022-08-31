using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    public class Travel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime DepartureDate { get; set; }
        public int Duration { get; set; }
        public Destination Destination { get; set; }
        public Guide Guide { get; set; }
    }
}
