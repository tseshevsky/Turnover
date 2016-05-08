using System;

namespace Turnover.Command.Contract
{
    public interface ICommand
    {
        
    }

    public interface ICommand<in T> where T: class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
