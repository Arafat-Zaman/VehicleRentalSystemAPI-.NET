namespace VehicleRentalSystemAPI.Models
{
    public class Bike : Vehicle
    {
        public string BikeType { get; set; }

        public override decimal CalculateRentalFee(int rentalDays)
        {
            return base.CalculateRentalFee(rentalDays); // No extra fee for bikes
        }
    }
}
