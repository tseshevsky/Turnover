using System;

namespace Turnover.PersistentModel
{
    public class PhoneNumber : IEntity
    {
        public Guid Id { get; set; }

        public Guid ContactID { get; set; }

        public string CountryCode { get; set; }

        public string OperatorCode { get; set; }

        public string Number { get; set; }
    }
}
