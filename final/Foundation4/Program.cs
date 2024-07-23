using System;
using System.Diagnostics;
namespace ExerciseTracking{
    class Program
    {
        static void Main(string[] args)
        {
            List<Exercise> exercises = new List<Exercise>{
                new Running(){
                    date = "22 July, 2024",
                    durationOfActivity = 30,
                    distance = 2.0
                },
                new Biking(){
                    date = "22 July, 2024",
                    durationOfActivity = 45,
                    speed = 10.0
                },
                new Swimming(){
                    date = "22 July, 2024",
                    durationOfActivity = 60,
                    laps = 30
                }
            };
            foreach(Exercise exercise in exercises){
                exercise.GetSummary();
            }
        }
    }  
}