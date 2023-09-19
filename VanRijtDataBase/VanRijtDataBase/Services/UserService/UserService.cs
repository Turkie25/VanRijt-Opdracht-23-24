using Microsoft.EntityFrameworkCore;
using VanRijtDataBase.Models;

namespace VanRijtDataBase.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DBContext _dbContext;
        private readonly IMapper _mapper;
        public UserService(DBContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ServiceResponce<GetUserResponseDto>> GetUserById(int id)
        {
            var serviceResponce = new ServiceResponce<GetUserResponseDto>();

            // Use async method to query the database
            var user = await _dbContext.User.FirstOrDefaultAsync(x => x.UserID == id);

            if (user == null)
            {
                throw new Exception("No User Found");
            }
            serviceResponce.Data = _mapper.Map<GetUserResponseDto>(user);
            return serviceResponce;
        }

        public async Task<ServiceResponce<List<GetUserResponseDto>>> GetUsers()
        { 
            var users = await _dbContext.User.ToListAsync();
            var serviceResponce = new ServiceResponce<List<GetUserResponseDto>>
            {
                Data = users.Select(c => _mapper.Map<GetUserResponseDto>(c)).ToList()
            };
            return serviceResponce;
        }

        public async Task<ServiceResponce<User>> PostUsers(User newUser)
        {
            _dbContext.User.Add(newUser);
            await  _dbContext.SaveChangesAsync();
            var serviceResponce = new ServiceResponce<User>
            {
                Data = newUser
            };
                        
            return serviceResponce;

        }
    }
}

