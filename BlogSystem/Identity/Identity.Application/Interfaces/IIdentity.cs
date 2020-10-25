using Common.Application;
using Identity.Application.Commands.ChangePasswordCommand;
using Identity.Application.Commands.CreateUserCommand;
using Identity.Application.Commands.LoginUserCommand;
using System.Threading.Tasks;

namespace Identity.Application.Interfaces
{
    public interface IIdentity
    {
        Task<Result<LoginUserOutputModel>> Login(LoginUserInputModel loinInputModel);

        Task<Result<LoginUserOutputModel>> ChangePassword(ChangePasswordInputModel loinInputModel);

        Task<Result<LoginUserOutputModel>> Register(RegisterInputModel loinInputModel);
    }
}
