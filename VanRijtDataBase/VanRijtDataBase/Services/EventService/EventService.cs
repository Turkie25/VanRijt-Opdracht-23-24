using VanRijtDataBase.Dtos.Event;
using VanRijtDataBase.Repositories.EventRepository;
using VanRijtDataBase.Repositories.AdresRepository;
using System.ComponentModel;
using VanRijtDataBase.Repositories.UserRepository;

namespace VanRijtDataBase.Services.EventService
{
    public class EventService : IEventService
    {
        private readonly IUserRepository _userRepository;
        private readonly IAdresRepository _adresRepository;
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public EventService(IEventRepository eventRepository,IAdresRepository adresRepository,IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _eventRepository = eventRepository;
            _adresRepository = adresRepository;
            _mapper = mapper;

        }
        public async Task<ServiceResponse<Evenement>> PostEvent(PostEventDto evenement)
        {
            ServiceResponse<Evenement> serviceResponse = new();

            try
            {
                Adres adres = _mapper.Map<Adres>(evenement);

                Adres? existingAdres = await _adresRepository.GetAdres(adres);
                if (existingAdres == null)
                {
                    await _adresRepository.PostAdres(adres);
                }
                else
                {
                    adres = existingAdres; // Use the existing Adres
                }

                User? user = await _userRepository.GetUserByIdAsync(evenement.UserID);
                Evenement newEvent = _mapper.Map<Evenement>(evenement);

                newEvent.User = user;
                newEvent.Adres = adres; // Assign the Adres to the Event
                newEvent = await _eventRepository.PostEvent(newEvent);

                


                serviceResponse.Data = newEvent;
                serviceResponse.Message = "Event created successfully.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "An error occurred while creating the event." + ex;
            }

            return serviceResponse;
        }
    }
}
