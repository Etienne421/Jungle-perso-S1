using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    public class Destination
    {
        public string Name { get; set; }
        public string region { get; set; }
        public Country Country { get; set; }
    }
}
