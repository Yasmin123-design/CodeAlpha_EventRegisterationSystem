namespace EventRegisterationSystem.Models.Repository
{
    public interface IEventRepository
    {
        List<Event> GetAll();
        Event GetById(int id);
        void AddEvent(Event eventt);
    }
}
