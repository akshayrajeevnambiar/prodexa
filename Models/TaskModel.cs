namespace TaskManagerAPI.Models
{
    public class TaskModel
    {
        // Unique identifier for the task
        public int Id { get; set; }

        // The title or name of the task
        public string Title { get; set; }

        // A detailed description of the task
        public string Description { get; set; }

        // Is the task completed or not?
        public bool IsCompleted { get; set; }

        // The date and time when the task is due
        public DateTime DueDate { get; set; }
    }
}
