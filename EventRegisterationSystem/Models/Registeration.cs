namespace EventRegisterationSystem.Models
{
    public class Registeration
    {
        public int UserId { get; set; }
        public int EventId { get; set; }
        public DateTime RegisterationDate { get; set; }
        public User? User { get; set; }
        public Event? Event { get; set; }

    }
}
