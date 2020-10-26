using Common.Application;
using Identity.Application.Commands;
using Identity.Application.Commands.ChangePasswordCommand;
using Identity.Application.Commands.LoginUserCommand;
using System.Threading.Tasks;

namespace Identity.Application.Interfaces
{
    public interface IIdentity
    {
        Task<Result<LoginUserOutputModel>> Login(BaseUserInputModel loinInputModel);

        Task<Result> ChangePassword(ChangePasswordInputModel loinInputModel);

        Task<Result> Register(BaseUserInputModel loinInputModel);
    }
}
