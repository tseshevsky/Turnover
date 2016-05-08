using System;
using System.Collections.Generic;

namespace Turnover.PersistentModel
{
    public class Sale : IEntity
    {
        public Guid Id { get; set; }

        public DateTime OrderDate { get; set; }

        public ICollection<SaleDetails> Details { get; set; }
    }
}
