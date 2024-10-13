using Microsoft.AspNetCore.Mvc;
using VehicleRentalSystemAPI.Models;
using VehicleRentalSystemAPI.Repositories;

namespace VehicleRentalSystemAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        [HttpGet]
        public IActionResult GetAvailableVehicles()
        {
            var vehicles = _vehicleRepository.GetAvailableVehicles();
            return Ok(vehicles);
        }

        [HttpGet("{id}")]
        public IActionResult GetVehicleById(int id)
        {
            var vehicle = _vehicleRepository.GetVehicleById(id);
            if (vehicle == null) return NotFound();
            return Ok(vehicle);
        }

        [HttpPost]
        public IActionResult AddVehicle([FromBody] Vehicle vehicle)
        {
            _vehicleRepository.AddVehicle(vehicle);
            return CreatedAtAction(nameof(GetVehicleById), new { id = vehicle.Id }, vehicle);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVehicle(int id, [FromBody] Vehicle vehicle)
        {
            if (id != vehicle.Id) return BadRequest();
            _vehicleRepository.UpdateVehicle(vehicle);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVehicle(int id)
        {
            _vehicleRepository.DeleteVehicle(id);
            return NoContent();
        }
    }
}
