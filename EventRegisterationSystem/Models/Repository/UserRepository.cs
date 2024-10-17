
namespace EventRegisterationSystem.Models.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly RegisterationContext context;
        public UserRepository(RegisterationContext _context)
        {
            context = _context;
        }
        public void AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public List<User> GetAll()
        {
            return context.Users.ToList();
        }

        public User GetById(int id)
        {
            return context.Users.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
