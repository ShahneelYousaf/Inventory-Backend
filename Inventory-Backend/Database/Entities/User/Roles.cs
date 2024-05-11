namespace Inventory_Backend.Database.Entities.User
{
    public class Roles : DynamicEntity
    {
        public string? Name { get; set; }
        public string? Claims { get; set; }
        public bool? Status { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
