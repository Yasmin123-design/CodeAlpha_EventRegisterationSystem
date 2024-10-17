
namespace EventRegisterationSystem.Models.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly RegisterationContext context;
        public EventRepository(RegisterationContext _context)
        {
            context = _context;
        }
        public void AddEvent(Event eventt)
        {
            context.Events.Add(eventt);
            context.SaveChanges();
        }

        public List<Event> GetAll()
        {
            return context.Events.ToList();
        }

        public Event GetById(int id)
        {
            return context.Events.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
