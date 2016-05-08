using System;
using System.Collections.Generic;

namespace Turnover.PersistentModel
{
    public class Purchase : IEntity
    {
        public Guid Id { get; set; }

        public DateTime OrderDate { get; set; }

        public virtual ICollection<PurchaseDetails> Details { get; set; }
    }
}
