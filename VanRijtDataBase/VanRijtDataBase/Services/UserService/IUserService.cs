
namespace VanRijtDataBase.Services.UserService
{
    public interface IUserService
    {
        Task<ServiceResponse<List<GetUserDto>>> GetUsers();

        Task<ServiceResponse<GetUserDto>> GetUserById(int id);

        Task<ServiceResponse<User>> PostUser(User newUser);
    }
}
