using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tollare.Api.Models.TrafikLab
{
    public class ResponseData
    {
        public string LatestUpdate { get; set; }
        public int DataAge { get; set; }
        public Bus[] Buses { get; set; }
    }
}
