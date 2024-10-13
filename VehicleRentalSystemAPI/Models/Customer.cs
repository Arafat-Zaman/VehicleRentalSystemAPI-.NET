namespace VehicleRentalSystemAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Rental> Rentals { get; set; }
    }
}
