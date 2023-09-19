using Microsoft.EntityFrameworkCore;

namespace VanRijtDataBase.Services.UserService
{
    public class UserService : IUserService
    {
        public DBContext _dbContext;
        public UserService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ServiceResponce<User>> GetUserById(int id)
        {
            var serviceResponce = new ServiceResponce<User>();

            // Use async method to query the database
            var user = await _dbContext.User.FirstOrDefaultAsync(x => x.UserID == id);

            if (user == null)
            {
                throw new Exception("No User Found");
            }
            serviceResponce.Data = user;
            return serviceResponce;
        }

        public async Task<ServiceResponce<List<User>>> GetUsers()
        { 
            var users = await _dbContext.User.ToListAsync();
            var serviceResponce = new ServiceResponce<List<User>>
            {
                Data = users
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

