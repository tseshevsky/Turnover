using System.Data.Entity;
using Turnover.PersistentModel;

namespace Turnover.EntityFramework
{
    public class TurnoverDbContext : DbContext
    {
        public TurnoverDbContext() : base() { }

        public DbSet<Contact> Contact { get; set; }
        public DbSet<PhoneNumber> PhoneNumber { get; set; }


    }
}
