using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turnover.EntityFramework;
using Turnover.Model.ContactMangement;

namespace Turnover.Command.Implementation.Contacts
{
    public class CreateContactCommandHandler : ICommandHandler<CreateContactCommand>
    {
        private readonly TurnoverDbContext _context;

        public CreateContactCommandHandler(TurnoverDbContext context)
        {
            _context = context;
        }

        public void Handle(CreateContactCommand command)
        {
            _context.Contact.Add(new Contact()
            {
                FirstName = command.FirstName
            });
        }
    }
}
