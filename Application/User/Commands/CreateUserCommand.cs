using Application.Messaging;
using MediatR;

namespace Application.User.Commands
{
    public sealed record CreateUserCommand(string name, int age) : ICommand;
}
