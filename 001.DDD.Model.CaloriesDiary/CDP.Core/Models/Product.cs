using System;
using CDP.Core.Architecture;

namespace CDP.Core.Models
{
    public class Product : Entity
    {
        public Product(Guid id, string name, int caloriesPer100g) : base(id)
        {
            Name = name;
            CaloriesPer100g = caloriesPer100g;
        }

        public string Name { get; }

        public int CaloriesPer100g { get; }
    }
}
