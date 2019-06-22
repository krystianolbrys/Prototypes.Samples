using System;
using System.Linq.Expressions;
using Specification.Pattern.Models;
using Specification.Pattern.Models.Enums;
using Specification.Pattern.Specification.Infrastructure;

namespace Specification.Pattern.Specification
{
    public class BikeTypeMtbSpecification : GenericSpecification<Bike>
    {
        public override Expression<Func<Bike, bool>> ToExpression() => 
            (bike) => bike.BikeType == BikeType.Mtb;
    }
}
