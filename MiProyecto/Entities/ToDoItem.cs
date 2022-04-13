using System;

namespace MiProyecto.Entities
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime? DateCompleted { get; set; }
    }
}
