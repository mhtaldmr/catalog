using Microsoft.AspNetCore.Mvc;
using Vega.Models;

namespace Vega.Controllers
{
    [Route("api/vehicles")]
    public class VehiclesController : Controller
    {
        [HttpPost]
        public IActionResult CreateVehicle( [FromBody] Vehicle vehicle)
        {
            if (vehicle is null) //if the user not send any data, we will return bad request
                return BadRequest("No data entered!");


            return Ok(vehicle);
        }

    }
}
