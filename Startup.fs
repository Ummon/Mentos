namespace Mentos

open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.DependencyInjection
open WebSharper.AspNetCore

type Startup () =

    member this.ConfigureServices (services : IServiceCollection) =
        services
            .AddSitelet(Site.Main)
            .AddAuthentication("WebSharper")
            .AddCookie("WebSharper", fun _options -> ())
        |> ignore

    member this.Configure (app : IApplicationBuilder, env : IHostingEnvironment) =
        if env.IsDevelopment () then
            app.UseDeveloperExceptionPage () |> ignore

        app
            .UseAuthentication()
            .UseStaticFiles()
            .UseWebSharper()
            .Run(
                fun context ->
                    context.Response.StatusCode <- 404
                    context.Response.WriteAsync("Page not found")
            )