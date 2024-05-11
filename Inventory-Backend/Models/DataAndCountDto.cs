namespace Inventory_Backend.Models
{
    public class DataAndCountDto<T> where T : class
    {
        public List<T>? Data { get; set; }
        public int Count { get; set; }
    }
}
