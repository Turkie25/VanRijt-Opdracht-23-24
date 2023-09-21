
namespace VanRijtDataBase.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly DBContext _dbContext;

        public UserRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _dbContext.User
                .Where(x => x.UserID == id)
                .Include(x => x.Login)
                .FirstOrDefaultAsync();
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _dbContext.User.ToListAsync();
        }

        public async Task AddUserAsync(User newUser)
        {
            _dbContext.User.Add(newUser);
            await _dbContext.SaveChangesAsync();
        }
    }
}
