using System;
using Specification.Pattern.Models;
using Specification.Pattern.Models.Enums;
using Specification.Pattern.Specification;

namespace Specification.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var chosenBikeType = BikeType.Mtb;
            var mtbTypeChecker = new BikeTypeMtbSpecification();

            var bike = new Bike(chosenBikeType, 4500);
            var isMtb = mtbTypeChecker.IsSatisfiedBy(bike);

            Console.WriteLine(isMtb);
        }
    }
}
