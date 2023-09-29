using VanRijtDataBase.Dtos.Event;

namespace VanRijtDataBase.Services.EventService
{
    public interface IEventService
    {
        Task<ServiceResponse<Evenement>> PostEvent(PostEventDto evenement);
    }
}
