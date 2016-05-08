using System;
using System.Collections.Generic;

namespace Turnover.PersistentModel
{
    public class Client : IEntity
    {
        public Guid Id { get; set; }

        public Guid ContactId { get; set; }

        public Contact Contact { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}
