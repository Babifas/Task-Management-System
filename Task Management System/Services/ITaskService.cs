using Task_Management_System.Model;

namespace Task_Management_System.Services
{
    public interface ITaskService
    {
        List<UserTask> GetAllTasks();
        void AddTask(UserTask task);
    }
}
