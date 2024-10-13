using Microsoft.AspNetCore.Mvc;
using VehicleRentalSystemAPI.Data;
using VehicleRentalSystemAPI.Models;

namespace VehicleRentalSystemAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RentalController : ControllerBase
    {
        private readonly VehicleDbContext _context;

        public RentalController(VehicleDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult RentVehicle([FromBody] Rental rental)
        {
            var vehicle = _context.Vehicles.Find(rental.VehicleId);
            if (vehicle == null || !vehicle.IsAvailable)
                return BadRequest("Vehicle is not available");

            vehicle.IsAvailable = false;
            _context.Rentals.Add(rental);
            _context.SaveChanges();
            return Ok(rental);
        }

        [HttpGet]
        public IActionResult GetRentals()
        {
            var rentals = _context.Rentals.ToList();
            return Ok(rentals);
        }
    }
}
