module Express

open Fable.Core
// open Fable.Core.JsInterop

type Response =
    abstract send: string -> unit

type Application =
    abstract get: string -> (obj -> Response -> unit) -> unit
    abstract listen: int -> (unit -> unit) -> unit

// Not working
// let inline Express (): Application = importDefault "express"

[<ImportDefault("express")>]
let inline Express (): Application = jsNative
