namespace Pipseek.Model
{
    public class DailyTask : Entity
    {
        public string? Note { get; set; }
        public TimeOfDay TimeOfDay { get; set; }

        public Guid UserId { get; set; }

        public DateTime Date { get; set; }

        public bool IsCompleted { get; set; }
    }
}