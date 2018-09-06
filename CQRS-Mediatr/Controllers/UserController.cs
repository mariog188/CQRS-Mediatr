using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CQRS_Mediatr.Application.Models;
using CQRS_Mediatr.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Mediatr.Controllers
{
    public class UserController : Controller
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("user/{firstName}")]
        public async Task<IActionResult> Create(CreateUserQuery query, CancellationToken cancellationtoken)
        {
            UserViewModel viewModel = await _mediator.Send(query, cancellationtoken);

            return new OkObjectResult(  viewModel);
        }
    }
}