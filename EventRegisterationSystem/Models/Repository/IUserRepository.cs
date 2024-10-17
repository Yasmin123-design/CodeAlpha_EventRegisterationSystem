namespace EventRegisterationSystem.Models.Repository
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User GetById(int id);
        void AddUser(User user);
    }
}
