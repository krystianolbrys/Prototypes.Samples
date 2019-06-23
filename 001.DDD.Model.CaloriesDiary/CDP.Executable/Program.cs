using System;
using System.Collections.Generic;
using CDP.Core.Models;

namespace CDP.Executable
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product(Guid.NewGuid(), "Kurczak", 111);
            var meal = new Meal(Guid.NewGuid(), 110, DateTime.UtcNow, product);

            Console.WriteLine("CDP App -");
            var diary = new DayDiary(100,200, new List<Meal>() { meal });

            Console.WriteLine(diary.GetTodayMealsCalories);
        }
    }
}
