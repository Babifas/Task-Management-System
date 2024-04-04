using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using Task_Management_System.Model;

namespace Task_Management_System.Services
{
    public class TaskService:ITaskService
    {
        private readonly IDbConnection _dbConnection;
        public TaskService(IConfiguration configuration)
        {
            _dbConnection = new MySqlConnection(configuration["ConnectionStrings:DefaultConnection"]);
        }
       public List<UserTask> GetAllTasks()
        {
            return _dbConnection.Query<UserTask>("SELECT * FROM TASKS").ToList();
        }
        public void AddTask(UserTask task)
        {
            _dbConnection.Execute("INSERT INTO TASKS VALUES(@taskId,@title,@status)", task);
        }
    }
}
