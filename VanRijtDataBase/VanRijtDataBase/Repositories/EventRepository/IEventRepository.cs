using VanRijtDataBase.Dtos.Event;

namespace VanRijtDataBase.Repositories.EventRepository
{
    public interface IEventRepository
    {
        Task<Evenement> PostEvent(Evenement evenement);

    }
}
