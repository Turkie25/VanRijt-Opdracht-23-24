namespace VanRijtDataBase.Repositories.UserRepository
{
    public interface IUserRepository
    {
        Task<User?> GetUserByIdAsync(int id);
        Task<List<User>> GetUsersAsync();
        Task AddUserAsync(User newUser);
    }
}
