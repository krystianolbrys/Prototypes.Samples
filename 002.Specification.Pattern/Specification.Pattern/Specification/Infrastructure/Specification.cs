using System;
using System.Linq.Expressions;

namespace Specification.Pattern.Specification.Infrastructure
{
    public abstract class GenericSpecification<T>
    {
        public abstract Expression<Func<T, bool>> ToExpression();

        public bool IsSatisfiedBy(T entity) => ToExpression().Compile().Invoke(entity);
    }
}
