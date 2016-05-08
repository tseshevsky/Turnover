using System;

namespace Turnover.PersistentModel
{
    public interface IHaveId
    {
        Guid Id { get; set; }
    }
}