using System;

namespace Turnover.PersistentModel
{
    public class PurchaseDetails : IEntity
    {
        public Guid Id { get; set; }

        public Guid PurchaseId { get; set; }

        public Guid ProductId { get; set; }

        public Guid Quantity { get; set; }

        public decimal Price { get; set; }

        public virtual Product Product { get; set; }
    }
}