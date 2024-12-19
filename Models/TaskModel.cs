using System.ComponentModel.DataAnnotations;

namespace _932220.titarenko.nikita.lab13.Models
{
    public class TaskModel
    {
        public int a {  get; set; }
        public int b { get; set; }
        public int operation { get; set; }
        public int solve { get; set; }
        [Required(ErrorMessage = "Необходимо ввести ответ!")]
        [Range(-1000, 1000)]
        public string answer { get; set; }
        public string question { get; set; }

        public TaskModel()
        {
            Random random = new Random();
            operation = random.Next(0, 1);
            a = random.Next(0, 11);
            b = random.Next(0, 11);

            switch (operation)
            {   
                case 0:
                    solve = a + b;
                    question = a + " + " + b + " = ";
                    break;
                case 1:
                    solve = a - b;
                    question = a + " - " + b + " = ";
                    break;
            }
        }
    }
}
