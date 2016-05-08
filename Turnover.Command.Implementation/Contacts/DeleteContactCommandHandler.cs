using System;
using Turnover.EntityFramework;
using Turnover.Model.ContactMangement;

namespace Turnover.Command.Implementation.Contacts
{
    public class DeleteContactCommandHandler : ICommandHandler<DeleteContactCommand>
    {
        private readonly TurnoverDbContext _context;

        public DeleteContactCommandHandler(TurnoverDbContext context)
        {
            _context = context;
        }

        public void Handle(DeleteContactCommand command)
        {
            _context.Contact.Remove(new Contact
            {
                Id = command.Id
            });
        }
    }
}