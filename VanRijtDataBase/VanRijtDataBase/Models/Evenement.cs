namespace VanRijtDataBase.Models
{
    public class Evenement
    {
        public int EvenementID { get; set; }

        public int MaxBezoekers { get; set; }

        public DateTime Start { get; set; }

        public DateTime Eind { get; set; }

        public Adres? Adres { get; set; }

        public string? EventNaam { get; set; }

        public User? User { get; set; }
    }
}
