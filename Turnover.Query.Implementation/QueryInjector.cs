using SimpleInjector;
using Turnover.Query.Contract;

namespace Turnover.Query.Implementation
{
    public class QueryInjector
    {
        public void Register(Container container)
        {
            container.RegisterSingleton<IQueryableDatabase, QueryableDatabase>();
        }
    }
}
