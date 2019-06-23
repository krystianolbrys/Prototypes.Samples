using System;
using CDP.Core.Architecture;

namespace CDP.Core.Models
{
    public class Meal : Entity
    {
        public Meal(Guid id, int weight, DateTime consumptionDate, Product product) : base(id)
        {
            Product = product ??
                throw new ArgumentNullException("Product jest null");

            Weight = weight;
            ConsumptionDate = consumptionDate;
            
        }

        public int Weight { get; }
        public DateTime ConsumptionDate { get; }
        public Product Product { get; }
    }
}
