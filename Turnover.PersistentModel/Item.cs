using System;

namespace Turnover.PersistentModel
{
    public class Item : IEntity
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public Guid PurchaseId { get; set; }

        public Guid SaleId { get; set; }

        public string ItemName { get; set; }

        public string ItemDescription { get; set; }

        public string ItemUniqueIdentifier { get; set; }

        public virtual Product Product { get; set; }
    }
}
