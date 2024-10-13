namespace VehicleRentalSystemAPI.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public bool IsAvailable { get; set; }

        public virtual decimal CalculateRentalFee(int rentalDays)
        {
            return RentalPricePerDay * rentalDays;
        }
    }
}
