using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Commands.ChangePasswordCommand
{
    public class ChangePasswordInputModel
    {
        public string UserId { get; set; } = default;

        public string NewPassword { get; set; } = default;

        public string CurrentPassword { get; set; } = default;
    }
}
