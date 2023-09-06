namespace VanRijtDataBase.Model
{
    public class EvenementData
    {
        public int EvenementDataID { get; set; }

        public Evenement Evenement { get; set; }

        public TimeOnly Tijd { get; set; }

        public int Instroom {  get; set; }

        public int Uitstroom { get; set; }

        public Enums.Weer Weer {  get; set; }

        public int Tempratuur { get; set; }

        public string Notitie { get; set; }
    }
}
