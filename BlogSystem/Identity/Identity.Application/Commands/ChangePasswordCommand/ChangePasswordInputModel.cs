using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Commands.ChangePasswordCommand
{
   public  class ChangePasswordInputModel
    {
        public ChangePasswordInputModel(
           string userId,
           string currentPassword,
           string newPassword)
        {
            this.UserId = userId;
            this.CurrentPassword = currentPassword;
            this.NewPassword = newPassword;
        }

        public string UserId { get; }

        public string CurrentPassword { get; }

        public string NewPassword { get; }
    }
}
