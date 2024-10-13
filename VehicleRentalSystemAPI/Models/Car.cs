namespace VehicleRentalSystemAPI.Models
{
    public class Car : Vehicle
    {
        public string FuelType { get; set; }

        public override decimal CalculateRentalFee(int rentalDays)
        {
            return base.CalculateRentalFee(rentalDays) + 50; // Cars have additional fee
        }
    }
}
