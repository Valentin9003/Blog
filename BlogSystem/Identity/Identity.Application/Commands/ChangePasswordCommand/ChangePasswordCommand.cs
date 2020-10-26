using Common.Application;
using Common.Application.Contracts;
using Identity.Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Application.Commands.ChangePasswordCommand
{
    public class ChangePasswordCommand : IRequest<Result>
    {
        public string NewPassword { get; set; } = default;

        public string CurrentPassword { get; set; } = default;

        public class ChangePasswordCommandHandler : IRequestHandler<ChangePasswordCommand, Result>
        {
            private readonly IIdentity Identity;
            private readonly ICurrentUser currentUser;

            public ChangePasswordCommandHandler(IIdentity identity)
            {
                this.Identity = identity;
            }

            public async Task<Result> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
            {
                var result =  await this.Identity.ChangePassword(new ChangePasswordInputModel(
                    this.currentUser.UserId, 
                    request.NewPassword, 
                    request.CurrentPassword));

                return result.Succeeded;
            }
        }
    }
}
