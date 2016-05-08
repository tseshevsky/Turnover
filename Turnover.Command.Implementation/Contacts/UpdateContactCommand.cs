using System;
using System.Collections.Generic;
using Turnover.Model.ContactMangement;

namespace Turnover.Command.Implementation.Contacts
{
    public class UpdateContactCommand
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