using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    public class TravelRecommendation
    {
        public string DangerLevel { get; set; }
        public string Description { get; set; }
        public string Attribut { get; set; }
        public Travel Travel { get; set; }
    }
}
