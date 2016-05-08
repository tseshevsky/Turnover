using System;

namespace Turnover.PersistentModel
{
    public class EmailAddress : IEntity
    {
        public Guid Id { get; set; }

        public Guid ContactId { get; set; }

        public string Address { get; set; }
    }
}
