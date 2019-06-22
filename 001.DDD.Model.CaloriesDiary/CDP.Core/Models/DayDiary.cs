using System;
using System.Collections.Generic;
using System.Linq;

namespace CDP.Core.Models
{
    public class DayDiary
    {
        private readonly IList<Meal> _newMeals;
        private readonly IReadOnlyList<Meal> _todayMeals;
        private int _actualCalories { get; set; }

        public int OptimalMaxiumumCalories { get; }

        public DayDiary(int optimalMaxiumumCalories, int actualCalories, ICollection<Meal> todayMeals)
        {
            _todayMeals = todayMeals.ToList().AsReadOnly() ?? 
                throw new ArgumentNullException("todayMeals jest null");

            _newMeals = new List<Meal>();

            _actualCalories = actualCalories;

            OptimalMaxiumumCalories = optimalMaxiumumCalories;
        }

        public void AddMeal(Meal meal)
        {
            if (meal == null)
            {
                throw new ArgumentNullException("Meal nie moży być null");
            }

            _newMeals.Add(meal);
        }

        public IReadOnlyList<Meal> GetTodayMeals => _todayMeals;
        public IReadOnlyList<Meal> GetNewMeals => _newMeals.ToList().AsReadOnly();
    }
}
