namespace VehicleRentalSystemAPI.Models
{
    public class Truck : Vehicle
    {
        public int LoadCapacity { get; set; }

        public override decimal CalculateRentalFee(int rentalDays)
        {
            return base.CalculateRentalFee(rentalDays) + 100; // Trucks have extra fees
        }
    }
}
