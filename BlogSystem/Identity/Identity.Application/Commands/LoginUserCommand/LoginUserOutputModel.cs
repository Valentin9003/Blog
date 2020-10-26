using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Commands.LoginUserCommand
{
   public class LoginUserOutputModel
    {
        public LoginUserOutputModel(string token)
        {
            this.Token = token;
        }
        public string UserId { get; set; } = default;

        public string Token { get; set; } = default;
    }
}
