namespace VanRijtDataBase.Services.EventService
{
    public interface IEventService
    {
        Task<ServiceResponse<Evenement>> PostEvent(Evenement evenement);
    }
}
