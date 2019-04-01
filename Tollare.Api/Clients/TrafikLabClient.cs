using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Tollare.Api.Interfaces;
using Tollare.Api.Models.TrafikLab;

namespace Tollare.Api.Clients
{
    public class TrafikLabClient : ITrafikLabClient
    {
        private readonly HttpClient _client;
        private readonly string _apiKeyRealTime;

        public TrafikLabClient(HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _apiKeyRealTime = configuration.GetSection("TrafikLab").GetValue<string>("ApiKeyRealTime");
        }

        public async Task<Response> GetRealTimeInfoById(int siteId)
        {
            var queryParam = $"?key={_apiKeyRealTime}&siteid={siteId}&timewindow=60";
            var data = await _client.GetStringAsync(queryParam);
            return JsonConvert.DeserializeObject<Response>(data);
        }
    }
}
