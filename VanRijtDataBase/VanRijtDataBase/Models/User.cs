namespace VanRijtDataBase.Models
{
    public class User
    {
        public int UserID { get; set; }

        public Login? Login { get; set; }

        public string? BedrijfsNaam { get; set; }

        public string? TelefoonNummer { get; set; }

        public string? Logo {  get; set; }

        public Enums.UserType UserType { get; set; }
    }
}
