using System;

namespace Turnover.PersistentModel
{
    public class Shipment : IEntity
    {
        public Guid Id { get; set; }

        public DateTime Sent { get; set; }

        public DateTime Arrived { get; set; }

        public decimal Price { get; set; }

        public decimal Brokerage { get; set; }
    }
}
