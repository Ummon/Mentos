namespace Mentos

open System
open WebSharper
open FSharp.Data.Runtime.StructuralInference

[<JavaScript>]
module Types =
    type Classifying = None | Real | Fake

    type Articles =
        {
            Id : int
            UserClassifying : Classifying
        }

    type Result =
        {
            ArticleId : int
            Classifying : Classifying
        }

    type State =
        | NotStarted
        | Finished of Articles * Result List
        | InProgress of Articles
