using System;

namespace Turnover.PersistentModel
{
    public class Warehouse : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
