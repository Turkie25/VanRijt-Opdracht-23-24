namespace VanRijtDataBase.Models
{
    public class ServiceResponce<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string? Message { get; set; }
    }
}
