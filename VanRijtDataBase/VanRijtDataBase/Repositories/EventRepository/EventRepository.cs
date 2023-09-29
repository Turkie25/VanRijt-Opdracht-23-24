namespace VanRijtDataBase.Repositories.EventRepository
{
    public class EventRepository : IEventRepository
    {
        private readonly DBContext _dbContext;

        public EventRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task PostEvent(Evenement evenement)
        {
            _dbContext.Evenement.Update(evenement);
            await _dbContext.SaveChangesAsync();
        }
    }
}