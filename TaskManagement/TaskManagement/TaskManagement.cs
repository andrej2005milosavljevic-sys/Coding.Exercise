using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    internal class TaskManagement
    {
        public List<TaskItem> tasks = new List<TaskItem>();

        public void AddTask(int id, string title, DateTime dueDate,TaskStatus status)
        {
            tasks.Add(new TaskItem
            {
                Id = id,
                Title = title,
                DueDate = dueDate,
                Status = status
            });
        }
        public int TaskCount()
        {
            return tasks.Count;
        }

        public bool ChangeTaskStatus(int id, TaskStatus status)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.Status = status;
                return true;
            }
            return false;
        }

        public TaskItem FindTaskById(int id)
        {
            return tasks.FirstOrDefault(t => t.Id == id);
        }
        public List<TaskItem> GetTasksDueToday()
        {
            return tasks
                .Where(t => t.DueDate.Date == DateTime.Today)
                .OrderBy(t => t.DueDate)
                .ToList();
        }




    }
