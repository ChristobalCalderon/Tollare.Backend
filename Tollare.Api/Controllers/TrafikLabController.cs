using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tollare.Api.Interfaces;

namespace Tollare.Api.Controllers
{
    [Route("api/[controller]")]
    public class TrafikLabController : ControllerBase
    {
        private readonly ITrafikLabClient _client;

        public TrafikLabController(ITrafikLabClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await _client.GetRealTimeInfoById(4113);
            return Ok(result);
        }
    }
}
