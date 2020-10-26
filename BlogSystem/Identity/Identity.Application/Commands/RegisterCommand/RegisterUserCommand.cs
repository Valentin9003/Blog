using Common.Application;
using Identity.Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Application.Commands.RegisterCommand
{
    public class RegisterUserCommand : BaseUserInputModel, IRequest<Result>
    {
        public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, Result>
        {
            private readonly IIdentity identity;

            public RegisterUserCommandHandler(IIdentity identity)
            {
                this.identity = identity;
            }
            public async Task<Result> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
            {
                var result =  await this.identity.Register(request);

                return result;
            }
        }
    }
}
