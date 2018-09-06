using CQRS_Mediatr.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Mediatr.Application.Models
{
    public class CreateUserQuery : IRequest<UserViewModel>
    {
        public string FirstName { get; set; }
    }
}
