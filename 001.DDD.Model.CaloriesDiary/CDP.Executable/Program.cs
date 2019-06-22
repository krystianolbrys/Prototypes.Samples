using System;
using System.Collections.Generic;
using CDP.Core.Models;

namespace CDP.Executable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CDP App -");
            var diary = new DayDiary(100,200, new List<Meal>() { new Meal()});

            diary.AddMeal(new Meal());

            Console.WriteLine(diary.GetTodayMeals.Count);
        }
    }
}
