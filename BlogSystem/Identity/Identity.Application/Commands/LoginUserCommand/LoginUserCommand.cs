using Common.Application;
using Identity.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Application.Commands.LoginUserCommand
{
    public class LoginUserCommand : LoginUserInputModel, IRequest<Result<LoginUserOutputModel>>
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
