using System.Linq.Expressions;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }

        // on prend un certain nombre d'article à afficher par page
        int Take { get; }
        // on skip ce nombre afin d'afficher le même nombre suivant dans la seconde page
        int Skip { get; }
        bool IsPagingEnable { get; }
    }
}