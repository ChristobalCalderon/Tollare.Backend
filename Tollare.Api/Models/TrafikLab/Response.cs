using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tollare.Api.Models.TrafikLab
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public int ExecutionTime { get; set; }
        public ResponseData ResponseData { get; set; }
    }
}
