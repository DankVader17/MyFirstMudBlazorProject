using Microsoft.EntityFrameworkCore;
using MyFirstMudBlazorProject.Data;
using MyFirstMudBlazorProject.Data.Models;

namespace MyFirstMudBlazorProject.Services
{
    public class TaskService : ITaskService
    {
        private readonly TaskDbContext _context;

        public TaskService(TaskDbContext context)
        {
            _context = context;
        }
        public void DeleteTask(int taskId)
        {
            var task = _context.MyTasks.FirstOrDefault(x => x.Id == taskId);
            if (task != null)
            {
                _context.MyTasks.Remove(task);
                _context.SaveChanges();
            }
        }

        public MyTask GetTaskById(int taskId)
        {
            return _context.MyTasks.SingleOrDefault(x => x.Id == taskId);
        }

        public List<MyTask> GetTasks()
        {
            return _context.MyTasks.ToList();
        }

        public void SaveTask(MyTask task)
        {
            if(task.Id == 0)
            {
                _context.MyTasks.Add(task);
            }
            else
            {
                _context.MyTasks.Update(task);
            }
            _context.SaveChanges();
        }
    }
}
