namespace VanRijtDataBase.Repositories.AdresRepository
{

        public class AdresRepository : IAdresRepository
        {
            private readonly DBContext _dbContext; // Assuming you're using Entity Framework or similar

            public AdresRepository(DBContext dbContext)
            {
                _dbContext = dbContext;
            }

            public Adres GetAdres(string straat, int huisNummer, string postCode)
            {
                return _dbContext.Adres
                    .FirstOrDefault(a => a.Straat == straat && a.HuisNummer == huisNummer && a.PostCode == postCode);
            }

            public void Add(Adres adres)
            {
                _dbContext.Adres.Add(adres);
                _dbContext.SaveChanges();
            }
        }
     
}
