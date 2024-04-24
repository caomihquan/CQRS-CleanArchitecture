using Application.Messaging;
using Domain.Dtos;
using Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User.Queries
{
    public class GetAllUserQueryHandler : IQueryHandler<GetAllUserQuery, IEnumerable<UserReponse>>
    {
        public async Task<Result<IEnumerable<UserReponse>>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var re = new UserReponse() { Age = 1, FullName = "cmquan" };
            List<UserReponse> list = new List<UserReponse>
            {
                re
            };
            return list;
        }
    }
}
