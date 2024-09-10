using FirstApi.Classes;
using FirstApi.Communication.Requests;
using FirstApi.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    public class UserController : ApiBaseController
    {
        /*
         * Use body only in POST and PUT
         * Use the id from ROUTE
        */

        [HttpGet]
        [Route("{id}/")]
        [ProducesResponseType(typeof(User), statusCode: 200)]
        [ProducesResponseType(typeof(string), statusCode: 400)]
        public IActionResult Get([FromRoute]int id, [FromQuery]string name)
        {
            try
            {
                var user = new User { Id = 1, Name = "João", Age = 25 };

                return Ok(user);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterUser), statusCode: StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] RequestRegisterUser request)
        {
            var response = new ResponseRegisterUser() { Name = request.Name, Email = request.Email };

            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status204NoContent)]
        public IActionResult Update(
            [FromRoute] int id,
            [FromBody] RequestUpdateUser request)
        {
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status204NoContent)]
        public IActionResult Delete([FromRoute] int id)
        {
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<User>), statusCode: StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            var response = new List<User>(){
                new() {Id  = 1, Name = "teste", Age = 21},
                new() {Id  = 2, Name = "teste", Age = 21},
                new() {Id  = 3, Name = "teste", Age = 21},
                new() {Id  = 4, Name = "teste", Age = 21}
            };

            return Ok(response);
        }

        [HttpPut("change-password")]
        [ProducesResponseType(statusCode: StatusCodes.Status204NoContent)]
        public IActionResult ChangePassword(
            [FromBody] RequestChangePassword request)
        {
            return NoContent();
        }
    }
}
