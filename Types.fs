namespace Mentos

open System
open WebSharper
open FSharp.Data.Runtime.StructuralInference

[<JavaScript>]
module Types =
    type Classifying = None | Real | Fake

    type Article =
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
        | InProgress of Article list
        | FinishedUnvalidated of Article list
        | FinishedValidated of Article list * Result List
