using Common.Application;
using Identity.Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Application.Commands.LoginUserCommand
{
    public class LoginUserCommand : BaseUserInputModel, IRequest<Result<LoginUserOutputModel>> 
    {
        public class LoginUserHandler : IRequestHandler<LoginUserCommand, Result<LoginUserOutputModel>>
        {
            private readonly IIdentity Identity;

            public LoginUserHandler(IIdentity identity)
            {
                this.Identity = identity;
            }

            public async Task<Result<LoginUserOutputModel>> Handle(LoginUserCommand request, CancellationToken cancellationToken)
            {
                var result = await this.Identity.Login(request);

                if (!result.Succeeded)
                {
                    return result.Errors;
                }

                var token = result.Data;

                return new LoginUserOutputModel(token.Token);
            }
        }
    }
}
