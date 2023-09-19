




namespace VanRijtDataBase.Services.UserService
{
    public interface IUserService
    {
        Task<ServiceResponce<List<GetUserResponseDto>>> GetUsers();

        Task<ServiceResponce<GetUserResponseDto>> GetUserById(int id);

        Task<ServiceResponce<User>> PostUsers(User newUser);
    }
}
