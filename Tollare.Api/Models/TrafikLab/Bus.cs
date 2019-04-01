using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tollare.Api.Models.TrafikLab
{
    public class Bus
    {
        public string LineNumber { get; set; }
        public string Destination { get; set; }
        public string DisplayTime { get; set; }
        public string Deviations { get; set; }
    }
}
