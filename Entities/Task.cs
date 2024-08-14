namespace Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; } //Görev bitiş tarihi
        public bool IsCompleted { get; set; }

        public List<Reminder> Reminders { get; set; }

        public Task()
        {
            IsCompleted = false;
            Reminders = new List<Reminder>();
        }

        public void UpdateDetails(string title, string desc, DateTime dueDate)
        {
            this.Title = title;
            this.Description = desc;
            this.DueDate = dueDate;
        }

        public void AddReminder(Reminder reminder)
        {
            Reminders.Add(reminder);
        }
    }
}
