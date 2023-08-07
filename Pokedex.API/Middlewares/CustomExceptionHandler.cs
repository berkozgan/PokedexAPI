using Microsoft.AspNetCore.Diagnostics;
using Pokedex.Domain.DTOs;
using Pokedex.Service.Exceptions;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Pokedex.API.Middlewares
{
    public static class CustomExceptionHandler
    {
       
        public static void CustomException(this IApplicationBuilder app)
        {
            
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.ContentType = "application/json";
                    var exceptionFeature= context.Features.Get<IExceptionHandlerFeature>();

                    var StatusCode = exceptionFeature.Error switch
                    {
                        ClientSideException => 400,
                        NotFoundException => 404,
                        _ => 500
                    };
                    context.Response.StatusCode = StatusCode;
                    var response = CustomResponseDto<NoContentDto>.Fail(StatusCode, exceptionFeature.Error.Message);

                    //LOG

                    await context.Response.WriteAsync(JsonSerializer.Serialize(response));

                });
            });

        }


    }
}
