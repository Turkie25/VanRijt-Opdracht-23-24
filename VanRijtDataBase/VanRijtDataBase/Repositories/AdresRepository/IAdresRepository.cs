namespace VanRijtDataBase.Repositories.AdresRepository
{
    public interface IAdresRepository
    {
        Task<Adres?> GetAdres(Adres givenAdres);

        Task PostAdres(Adres adres);
        
    }
}
