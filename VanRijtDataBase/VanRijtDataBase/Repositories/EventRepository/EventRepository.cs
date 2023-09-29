using VanRijtDataBase.Dtos.Event;

namespace VanRijtDataBase.Repositories.EventRepository
{
    public class EventRepository : IEventRepository
    {
        private readonly DBContext _dbContext;

        public EventRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task PostEvent(PostEventDto evenement)
        {
            _dbContext.Evenement.Add(evenement);
            await _dbContext.SaveChangesAsync();
        }
    }
}