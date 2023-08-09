using MyFirstMudBlazorProject.Data.Models;


namespace MyFirstMudBlazorProject.Services
{
    public interface ITaskService
    {
        List<MyTask> GetTasks();
        MyTask GetTaskById(int taskId);
        void SaveTask(MyTask task);
        void DeleteTask(int taskId);

    }
}
