using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4
{
    public static class RegisterCustomPipeline
    {
        public static IApplicationBuilder UseRequestCulture(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestPipeline>();
        }
    }
}
