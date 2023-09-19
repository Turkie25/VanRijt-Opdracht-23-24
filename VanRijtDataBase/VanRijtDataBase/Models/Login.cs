namespace VanRijtDataBase.Models
{
    public class Login
    {
        public int LoginID { get; set; }

        public string? Username { get; set; } = null!;

        public string? Password { get; set; } = null!;

        public string? UserType { get; set; } = null!;
    }
}
