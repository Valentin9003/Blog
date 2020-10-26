using System.Threading.Tasks;
using Core.Web.Common;
using Identity.Application.Commands.ChangePasswordCommand;
using Identity.Application.Commands.LoginUserCommand;
using Identity.Application.Commands.RegisterCommand;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core.Web.Controllers
{
    public class IdentityController : ApiController
    {
        [HttpPost]
        [Route(nameof(Register))]
        public async Task<ActionResult> Register(RegisterUserCommand command) 
            => await this.Send(command);

        [HttpPost]
        [Route(nameof(Login))]
        public async Task<ActionResult<LoginUserOutputModel>> Login(LoginUserCommand command)
          => await this.Send(command);

        [HttpPut]
        [Authorize]
        [Route(nameof(Register))]
        public Task<ActionResult> ChangePassword(ChangePasswordCommand command)
         => this.Send(command);
    }
}
