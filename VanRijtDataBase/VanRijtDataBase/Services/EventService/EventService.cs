using VanRijtDataBase.Repositories.EventRepository;

namespace VanRijtDataBase.Services.EventService
{
    public class EventService : IEventService
    {

        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public EventService(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<Evenement>> PostEvent(Evenement evenement)
        {
            var serviceResponse = new ServiceResponse<Evenement>();
            await _eventRepository.PostEvent(evenement);
            serviceResponse.Data = evenement;
            return serviceResponse;
        }
    }
}
