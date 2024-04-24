using Application.Messaging;
using Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User.Commands
{
    internal class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
    {
        public async Task<Result> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            return Result.Success();
        }
    }
}
