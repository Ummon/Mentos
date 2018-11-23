namespace Mentos

open System
open WebSharper

module Server =

    [<Rpc>]
    let Reverse input =
        let reverse (s : string) =
            s.ToCharArray () |> Array.rev |> String.Concat

        async {
            return reverse input
        }

    [<Rpc>]
    let state () =
        async {
            return Types.NotStarted
        }


