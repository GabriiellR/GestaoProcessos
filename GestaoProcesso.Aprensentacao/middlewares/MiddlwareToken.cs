using GestaoProcessos.Aplicacao.Interfaces.Administracao;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

public class MiddlwareToken
{
    private readonly RequestDelegate _next;

    public MiddlwareToken(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, IApplicationServiceParametros secretKeyService)
    {
        var token = context.Items["Token"] as string;

        if (!string.IsNullOrEmpty(token))
        {
            try
            {
                var jwtToken = new JwtSecurityTokenHandler().ReadToken(token) as JwtSecurityToken;
                var empresaId = jwtToken?.Claims.FirstOrDefault(c => c.Type == "empresaId")?.Value;

                if (!string.IsNullOrEmpty(empresaId))
                {
                    var secretKey = secretKeyService.GetByEmpresa(int.Parse(empresaId));
                    var validationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey.Segredo)),
                        ClockSkew = TimeSpan.FromMinutes(5) // Ajuste conforme necessário
                    };

                    var handler = new JwtSecurityTokenHandler();
                    var principal = handler.ValidateToken(token, validationParameters, out var validatedToken);

                    if (validatedToken is JwtSecurityToken jwtSecurityToken)
                    {
                        context.User = new ClaimsPrincipal(new ClaimsIdentity(jwtSecurityToken.Claims));
                    }
                    else
                    {
                        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                        await context.Response.WriteAsync("Invalid token type");
                        return;
                    }
                }
                else
                {
                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    await context.Response.WriteAsync("EmpresaId not found in token");
                    return;
                }
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync($"Token validation failed: {ex.Message}");
                return;
            }
        }

        await _next(context);
    }
}
