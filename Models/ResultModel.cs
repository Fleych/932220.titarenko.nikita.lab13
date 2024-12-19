using System.Data;

namespace _932220.titarenko.nikita.lab13.Models
{
    public class ResultModel
    {
        public static int total_tasks = 0;
        public static int right_ans = 0;
        public static List<TaskModel> tasks = new List<TaskModel>();

        public static void Clear()
        {   
            total_tasks = 0;
            right_ans = 0;
            tasks.Clear();
        }
        public static void AddTask(TaskModel task)
        {
            tasks.Add(task);
        }
    }
}
