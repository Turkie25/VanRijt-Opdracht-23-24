namespace VanRijtDataBase.Models
{
    public class EvenementVeranderingen
    {
        public int Id { get; set; }

        public Evenement? Evenement { get; set; }

        public TimeOnly Tijd { get; set; }

        public string? Notitie { get; set; }
    }
}
