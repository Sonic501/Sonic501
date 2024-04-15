using Infrastructure.Settings;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Infrastructure.Configurations
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly AppSetting _appSettings;

        public JwtMiddleware(RequestDelegate next, IOptions<AppSetting> appSettings)
        {
            _next = next;
            _appSettings = appSettings.Value;
        }

        //public async Task Invoke(HttpContext context, IAuthService authService)
        //{
        //    var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
        //    if (token != null)
        //        await AttachUserToContext(context, authService, token);
        //    await _next(context);
        //}

        //private async Task AttachUserToContext(HttpContext context, IAuthService authService, string token)
        //{
        //    try
        //    {
        //        // Validate JWT token
        //        var tokenHandler = new JwtSecurityTokenHandler();
        //        var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
        //        tokenHandler.ValidateToken(token, new TokenValidationParameters
        //        {
        //            ValidateIssuerSigningKey = true,
        //            IssuerSigningKey = new SymmetricSecurityKey(key),
        //            ValidateIssuer = false,
        //            ValidateAudience = false,
        //            ClockSkew = TimeSpan.Zero
        //        }, out SecurityToken validatedToken);
        //        var jwtToken = (JwtSecurityToken)validatedToken;

        //        // Get user ID from token
        //        var id = Guid.Parse(jwtToken.Claims.First(x => x.Type == "id").Value);

        //        // Get user information
        //        var user = await authService.GetCustomerById(id);

        //        // Push the user into context
        //        context.Items["User"] = user;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
    }
}
