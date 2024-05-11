namespace Inventory_Backend.Models
{
    public class SearchFilter
    {
        public string? Search { get; set; }
        public int? Skip { get; set; }
        public int? Take { get; set; }
        public string? OrderBy { get; set; }
    }
}
