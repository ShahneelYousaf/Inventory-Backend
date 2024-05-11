namespace Inventory_Backend.Database.Entities.User
{
    public class Users : DynamicEntity
    {
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? HashPassword { get; set; }
        public string? Cnic { get; set; }
        public string? Mobile { get; set; }
        public string? Image { get; set; }
        public string? Address { get; set; }
        public Guid? RoleId { get; set; }
        public bool? Status { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
