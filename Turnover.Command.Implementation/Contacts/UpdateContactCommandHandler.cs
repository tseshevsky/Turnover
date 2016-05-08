using System;
using Turnover.EntityFramework;

namespace Turnover.Command.Implementation.Contacts
{
    public class UpdateContactCommandHandler: ICommandHandler<UpdateContactCommand>
    {
        private readonly TurnoverDbContext _context;

        public UpdateContactCommandHandler(TurnoverDbContext context)
        {
            _context = context;
        }

        public void Handle(UpdateContactCommand command)
        {
            throw new NotImplementedException();
        }
    }
}