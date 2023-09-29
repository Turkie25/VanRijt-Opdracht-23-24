namespace VanRijtDataBase.Repositories.EventRepository
{
    public interface IEventRepository
    {
        Task PostEvent(Evenement evenement);

    }
}
