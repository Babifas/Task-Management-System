using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_Management_System.Model;
using Task_Management_System.Services;

namespace Task_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService service) 
        { 
           _taskService = service;
        }

        [HttpGet]
        public List<UserTask> GetAllTasks()
        {
            return _taskService.GetAllTasks();
        }
        [HttpPost]
        public string AddTask(UserTask task)
        {
            _taskService.AddTask(task);
            return "added successfuly";
        }
    }
}
