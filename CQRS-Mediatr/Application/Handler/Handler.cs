using CQRS_Mediatr.Application.Models;
using CQRS_Mediatr.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Mediatr.Application.Handler
{
    public class Handler : IRequestHandler<CreateUserQuery, UserViewModel>
    {
        public async Task<UserViewModel> Handle(CreateUserQuery request, CancellationToken cancellationToken)
        {
            return new UserViewModel()
            {
                Id = 1,
                FirstName = request.FirstName
            };
        }
    }
}
