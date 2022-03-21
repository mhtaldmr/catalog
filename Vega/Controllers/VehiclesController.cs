using Microsoft.AspNetCore.Mvc;
using Vega.Models;
using System;
using System.Threading.Tasks;
using Vega.Controllers.Resources;
using AutoMapper;
using Vega.Persistance;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Vega.Controllers
{
    [Route("api/vehicles")]
    public class VehiclesController : Controller
    {
        private readonly IMapper mapper;
        private readonly VegaDbContext context;

        public VehiclesController(IMapper mapper, VegaDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }


        [HttpPost]
        public async Task<IActionResult> CreateVehicle( [FromBody] VehicleResource vehicleResource)
        {
            if (vehicleResource is null) //if the user not send any data, we will return bad request
                return BadRequest("No data entered!");

            var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);

            context.Vehicles.Add(vehicle);
            await context.SaveChangesAsync();

            return  Ok(vehicle);
        }

    }
}
