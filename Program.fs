namespace Mentos

open Microsoft.AspNetCore
open Microsoft.AspNetCore.Hosting

module Program =
    let BuildWebHost args =
        WebHost
            .CreateDefaultBuilder(args)
            .UseKestrel()
            .UseStartup<Startup>()
            .Build()

    [<EntryPoint>]
    let main args =
        (BuildWebHost args).Run ()
        0
