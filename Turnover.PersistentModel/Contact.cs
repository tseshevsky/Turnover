using System;
using System.Collections.Generic;

namespace Turnover.PersistentModel
{
    public class Contact : IEntity
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }

        public virtual ICollection<EmailAddress> Emails { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
