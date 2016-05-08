using System;

namespace Turnover.PersistentModel
{
    public class Address : IEntity
    {
        public Guid Id { get; set; }

        public Guid ContactID { get; set; }

        public string City { get; set; }

        public string AddressLine1 { get; set; }
    }
}
