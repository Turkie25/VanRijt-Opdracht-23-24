namespace VanRijtDataBase.Repositories.AdresRepository
{
    public interface IAdresRepository
    {
        Task GetAdres(string straat, int huisNummer, int postCode);
    }
}
