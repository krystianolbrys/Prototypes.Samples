using Specification.Pattern.Models.Enums;

namespace Specification.Pattern.Models
{
    public class Bike
    {
        public Bike(BikeType bikeType, int price)
        {
            BikeType = bikeType;
            Price = price;
        }

        public BikeType BikeType { get; }
        public int Price { get; }
    }
}
