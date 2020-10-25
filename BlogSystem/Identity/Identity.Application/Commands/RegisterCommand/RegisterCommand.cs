using Common.Application;
using Identity.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Application.Commands.RegisterCommand
{
    public class RegisterCommand : BaseUserInputModel, IRequest<Result>
    {
        public class RegisterCommandHandler : IRequestHandler<RegisterCommand, Result>
        {
            private readonly IIdentity identity;

            public RegisterCommandHandler(IIdentity identity)
            {
                this.identity = identity;
            }
            public Task<Result> Handle(RegisterCommand request, CancellationToken cancellationToken)
            {
                var result =  this.identity.Register(request);

                return result;
            }
        }
    }
}
