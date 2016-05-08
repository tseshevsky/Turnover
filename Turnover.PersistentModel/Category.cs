using System;

namespace Turnover.PersistentModel
{
    public class Category : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
