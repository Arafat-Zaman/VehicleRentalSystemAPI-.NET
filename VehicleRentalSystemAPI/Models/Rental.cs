namespace VehicleRentalSystemAPI.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public string CustomerName { get; set; }
        public DateTime RentalDate { get; set; }
        public int RentalDays { get; set; }

        public decimal TotalPrice => Vehicle.CalculateRentalFee(RentalDays);
    }
}
