using System;

namespace Turnover.PersistentModel
{
    public class OrderLine : IEntity
    {
        public Guid Id { get; set; }

        public Guid SaleId { get; private set; }

        public Guid ProductId { get; private set; }

        public Guid Quantity { get; private set; }
    }
}
