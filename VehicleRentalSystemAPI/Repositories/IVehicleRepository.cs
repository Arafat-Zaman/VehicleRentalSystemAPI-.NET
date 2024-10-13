using VehicleRentalSystemAPI.Models;

namespace VehicleRentalSystemAPI.Repositories
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetAvailableVehicles();
        Vehicle GetVehicleById(int id);
        void AddVehicle(Vehicle vehicle);
        void UpdateVehicle(Vehicle vehicle);
        void DeleteVehicle(int id);
    }
}
