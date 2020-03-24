using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task1, string> TaskSolver = task =>
            {
                // Your solution goes here
                // You can get all needed inputs from task.[Property]
                // Good luck!
                float numberOfSickPeople = float.Parse(task.City.Population) * float.Parse(task.City.SickPercentage);
                float numberOfDeath = float.Parse(task.Virus.KillProbability) * numberOfSickPeople;

                string answer = "There are " + Math.Truncate(numberOfSickPeople)
                + " people sick with " + task.Virus.Name
                + " in the city of " + task.City.Name + ", "
                + Math.Truncate(numberOfDeath) + " of which died";

                return answer;
            };

            Task1.CheckSolver(TaskSolver);
        }
    }
}
