namespace Entities
{
    public  class Reminder
    {
        public int Id { get; set; }
        public Guid TaskId { get; set; }
        public TimeSpan TimeBeforeDue { get; set; } //Görevin bitiş tarihinden kaç gün önceden bildirim göndermeye başlamalı

        public Assigment Assigment { get; set; }

    }
}
