using System.Diagnostics;
using _932220.titarenko.nikita.lab13.Models;
using Microsoft.AspNetCore.Mvc;

namespace _932220.titarenko.nikita.lab13.Controllers
{
    public class MockupsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Quiz()
        {
            ResultModel.Clear();
            TaskModel task = new TaskModel();
            ResultModel.AddTask(task);
            return View(task);
        }

        [HttpPost]
        public IActionResult Quiz(TaskModel task, string action)
        {
            if (!ModelState.IsValid)
            {
                return View(ResultModel.tasks.Last());
            }
            
            ResultModel.tasks.Last().answer = task.answer;
            if (ResultModel.tasks.Last().solve == Convert.ToInt32(task.answer)) ResultModel.right_ans++;

            ResultModel.total_tasks++;

            if (action == "Finish") return View("Result");

            TaskModel new_task = new TaskModel();
            ResultModel.AddTask(new_task);
            return View(new_task);
        }

        public IActionResult Result()
        {   
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
