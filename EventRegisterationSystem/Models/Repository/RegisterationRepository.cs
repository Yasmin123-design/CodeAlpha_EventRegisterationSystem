namespace EventRegisterationSystem.Models.Repository
{
    public class RegisterationRepository : IRegisterationRepository
    {
        private readonly RegisterationContext context;
        public RegisterationRepository(RegisterationContext _context)
        {
            context = _context;
        }
        public void AddRegisteration(Registeration registeration)
        {
            Event @event = context.Events.Where(x => x.Id == registeration.EventId).FirstOrDefault();
            @event.AvailableRegistrations -= 1;
            context.Registerations.Add(registeration);
            context.SaveChanges();
        }
    }
}
