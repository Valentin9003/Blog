using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Web.Common;
using Microsoft.AspNetCore.Mvc;

namespace Core.Web.Controllers
{
    public class IdentityController : ApiController
    {
        public Task<ActionResult> Register() => this.Mediator.Send();

        public Task<ActionResult> Login()
        {
            return null;
        }

        public Task<ActionResult> ChangePassword()
        {
            return null;
        }
    }
}
