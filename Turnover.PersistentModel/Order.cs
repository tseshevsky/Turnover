using System;
using System.Collections.Generic;

namespace Turnover.PersistentModel
{
    public class Order : IEntity
    {
        public Guid Id { get; set; }

        public DateTime OrderDate { get; private set; }

        public ICollection<OrderLine> Lines { get; private set; }
    }
}
