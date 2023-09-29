using VanRijtDataBase.Dtos.Event;

namespace VanRijtDataBase.Repositories.EventRepository
{
    public interface IEventRepository
    {
        Task PostEvent(PostEventDto evenement);

    }
}
