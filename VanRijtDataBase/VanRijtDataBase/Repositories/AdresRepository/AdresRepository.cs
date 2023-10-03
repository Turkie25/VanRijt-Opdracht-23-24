using Microsoft.AspNetCore.Http.HttpResults;

namespace VanRijtDataBase.Repositories.AdresRepository
{

        public class AdresRepository : IAdresRepository
        {
            private readonly DBContext _dbContext; // Assuming you're using Entity Framework or similar

            public AdresRepository(DBContext dbContext)
            {
                _dbContext = dbContext;
            }

        public async Task<Adres?> GetAdres(Adres givenAdres)
        {
            var adres = await _dbContext.Adres
                .FirstOrDefaultAsync(a => a.Straat == givenAdres.Straat && a.HuisNummer == givenAdres.HuisNummer && a.PostCode == givenAdres.PostCode);
            return adres;
        }



        public async Task PostAdres(Adres adres)
            {
                _dbContext.Adres.Add(adres);
               await _dbContext.SaveChangesAsync();
            }
        }
     
}
