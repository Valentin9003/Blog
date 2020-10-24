using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSystem.Web.Common
{
    public  static class ResultExtensions
    {
        public static async Task<ActionResult<TData>> ToActionResult<TData>(this Task<TData> resultTask)
        {
            var result = await resultTask;

            if (result == null)
            {
                return new NotFoundResult();
            }

            return result;
        }
    }
}
