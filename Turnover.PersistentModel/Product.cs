using System;

namespace Turnover.PersistentModel
{
    public class Product : IEntity
    {
        public Guid Id { get; set; }

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ProductCode { get; set; }

        public virtual Category Category { get; set; }
    }
}
