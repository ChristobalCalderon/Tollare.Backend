using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tollare.Api.Models.TrafikLab;

namespace Tollare.Api.Interfaces
{
    public interface ITrafikLabClient
    {
        Task<Response> GetRealTimeInfoById(int siteId);
    }
}
