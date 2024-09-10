using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ApiBaseController : ControllerBase
    {
        [HttpGet("Healty")]
        public IActionResult Healty()
        {
            return Ok("It's healty");
        }


        protected string GetCustomKey()
        {
            return Request.Headers["MyKey"].ToString();
        }
    }
}
