namespace Inventory_Backend.Database.Entities.User
{
    public class LoginHistory : DynamicEntity
    {
        public string? deviceId { get; set; }
        public string? Os { get; set; }
        public string? Location { get; set; }
        public string? Detail { get; set; }
    }
}
