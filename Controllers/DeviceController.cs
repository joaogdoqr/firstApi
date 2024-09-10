using FirstApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    public class DeviceController : ApiBaseController
    {
        [HttpGet]
        public IActionResult Get()
        {
            var key = GetCustomKey();

            var laptop = new Laptop();

            var model = laptop.GetModel();

            return Ok(key);
        }
    }
}
