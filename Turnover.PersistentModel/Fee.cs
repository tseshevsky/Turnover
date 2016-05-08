using System;

namespace Turnover.PersistentModel
{
    public class Fee : IEntity
    {
        public Guid Id { get; set; }

        public Guid FeeTypeId { get; set; }
    }
}
