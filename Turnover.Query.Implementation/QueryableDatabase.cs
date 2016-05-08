using System.Linq;
using Turnover.EntityFramework;
using Turnover.Query.Contract;

namespace Turnover.Query.Implementation
{
    public class QueryableDatabase : IQueryableDatabase
    {
        private readonly TurnoverDbContext _context;

        public QueryableDatabase(TurnoverDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Query<T>() where T : class
        {
            return _context.Set<T>();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
