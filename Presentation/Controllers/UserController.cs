using Application.User.Commands;
using Application.User.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Abstraction;
using System.Reflection;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ApiController
    {
        public UserController(ISender sender):base(sender)
        {
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await Sender.Send(new GetAllUserQuery());
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpPost("{name}/{age}")]
        public async Task<IActionResult> Create(string name,int age)
        {
            var result = await Sender.Send(new CreateUserCommand(name,age));
            return result.IsSuccess ? CreatedAtAction(nameof(Get),null,result) : NotFound(result.Error);
        }
    }
}