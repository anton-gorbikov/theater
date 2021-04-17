module Express

open Fable.Core
// open Fable.Core.JsInterop

type Response =
    abstract send : string -> unit

type Application =
    abstract get : string -> (obj -> Response -> unit) -> unit
    abstract listen : int -> (unit -> unit) -> unit
    abstract ``use`` : string * (obj -> Response -> (unit -> unit)) -> unit
    abstract ``use`` : (obj -> Response -> (unit -> unit)) -> unit

type ApplicationStatic =
    abstract Create : unit -> Application
    abstract ``static`` : string -> unit

// Not working
// let inline Express (): Application = importDefault "express"

[<ImportDefault("express")>]
let Express : ApplicationStatic = jsNative
