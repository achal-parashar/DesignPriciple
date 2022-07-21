using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4
{
    public class RequestPipeline
    {
        private readonly RequestDelegate _next;
        public RequestPipeline(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var queryCulture = context.Request.Query["culture"];
            if(!string.IsNullOrEmpty(queryCulture))
            {
                var cultureinfo = new CultureInfo(queryCulture);
                CultureInfo.CurrentCulture = cultureinfo;
                CultureInfo.CurrentUICulture = cultureinfo;
            }
            await _next(context);
        }
    }
}
