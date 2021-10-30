namespace Pipseek.Model
{
    public class DailyTask : Entity
    {
        public string? Note { get; set; }
        public TimeOfDay TimeOfDay { get; set; }

        /// <summary>
        /// Do not use
        /// </summary>
        //public string TimeOfDayText { get { return this.TimeOfDay.ToString(); } set { this.TimeOfDayText = value; } } 

        public Guid UserId { get; set; }

        public DateTime Date { get; set; }

        public bool IsCompleted { get; set; }
    }
}