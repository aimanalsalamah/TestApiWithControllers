using Microsoft.AspNetCore.Mvc;

namespace TestApiWithControllers.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        [HttpGet("{val1}/{Val2}")]
        public int Get(int val1, int val2)
        {
            return val1 + val2;
        }
    }
}
