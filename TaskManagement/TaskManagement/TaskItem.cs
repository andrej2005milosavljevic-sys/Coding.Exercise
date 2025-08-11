using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public enum TaskStatus
    {
        NotStarted,
        InProgress,
        Completed,
        OnHold
    }
    internal class TaskItem
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public TaskStatus Status { get; set; }


    }
}
