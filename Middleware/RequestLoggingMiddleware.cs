using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace UserManagementAPI.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();
            await _next(context);
            stopwatch.Stop();

            var duration = stopwatch.ElapsedMilliseconds;
            var method = context.Request.Method;
            var path = context.Request.Path;
            var statusCode = context.Response.StatusCode;

            _logger.LogInformation("HTTP {Method} {Path} responded {StatusCode} in {Duration}ms", method, path, statusCode, duration);
        }
    }
}