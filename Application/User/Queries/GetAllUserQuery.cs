using Application.Messaging;
using Domain.Dtos;

namespace Application.User.Queries
{
    public sealed record GetAllUserQuery() : IQuery<IEnumerable<UserReponse>>;
}
