




namespace VanRijtDataBase.Services.UserService
{
    public interface IUserService
    {
        Task<ServiceResponce<List<User>>> GetUsers();

        Task<ServiceResponce<User>> GetUserById(int id);

        Task<ServiceResponce<User>> PostUsers(User newUser);
    }
}
