﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Commands.LoginUserCommand
{
    public class LoginUserInputModel
    {
        public string Username { get; set; } = default;

        public string Password { get; set; } = default;
    }
}
