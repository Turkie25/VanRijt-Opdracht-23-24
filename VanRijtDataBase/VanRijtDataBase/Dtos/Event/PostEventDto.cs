namespace VanRijtDataBase.Dtos.Event
{
    public class PostEventDto
    {
        public int MaxBezoekers { get; set; }

        public DateTime Start { get; set; }

        public DateTime Eind { get; set; }

        public string? Straat { get; set; }

        public int HuisNummer { get; set; }

        public string? PostCode { get; set; }

        public string? EventNaam { get; set; }

        public int UserID { get; set; }
    }
}
