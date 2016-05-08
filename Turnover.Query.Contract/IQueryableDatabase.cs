using System;
using System.Linq;

namespace Turnover.Query.Contract
{
    public interface IQueryableDatabase : IDisposable
    {
        IQueryable<T> Query<T>() where T : class;
    }
}
