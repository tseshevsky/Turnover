using System;

namespace Turnover.PersistentModel
{
    public class SaleDetails : IEntity
    {
        public Guid Id { get; set; }

        public Guid SaleID { get; set; }

        public Guid ProductID { get; set; }

        public Guid Quantity { get; set; }
    }
}
