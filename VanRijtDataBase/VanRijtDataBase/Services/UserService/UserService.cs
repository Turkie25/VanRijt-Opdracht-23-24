using VanRijtDataBase.Repositories.UserRepository;

namespace VanRijtDataBase.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }


        public async Task<ServiceResponse<GetUserDto>> GetUserById(int id)
        {
            var serviceResponse = new ServiceResponse<GetUserDto>();
            var user = await _userRepository.GetUserByIdAsync(id);

            if (user == null)
            {
                serviceResponse.Message = "User not found";
                return serviceResponse;
            }

            serviceResponse.Data = _mapper.Map<GetUserDto>(user);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetUserDto>>> GetUsers()
        {
            var serviceResponse = new ServiceResponse<List<GetUserDto>>();
            var users = await _userRepository.GetUsersAsync();

            if (users == null)
            {
                serviceResponse.Message = "No users found";
                return serviceResponse;
            }

            serviceResponse.Data = users.Select(_mapper.Map<GetUserDto>).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<User>> PostUser(User newUser)
        {
            var serviceResponse = new ServiceResponse<User>();
            await _userRepository.AddUserAsync(newUser);
            serviceResponse.Data = newUser;
            return serviceResponse;
        }
    }
}