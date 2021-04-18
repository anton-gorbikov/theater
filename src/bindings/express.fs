module express

open Fable.Core
// open Fable.Core.JsInterop

type Request =
    interface
    end

type Response =
    abstract send : string -> unit
    abstract sendFile : string -> unit

type RequestHandler = Request -> Response -> (unit -> unit) -> unit

type Application =
    abstract get : string -> (obj -> Response -> unit) -> unit
    abstract listen : int -> (unit -> unit) -> unit
    abstract ``use`` : string * RequestHandler -> unit
    abstract ``use`` : RequestHandler -> unit

type ApplicationStatic =
    [<Emit("new $0()")>]
    abstract Create : unit -> Application

    abstract ``static`` : string -> RequestHandler

// Not working
// let inline Express (): Application = importDefault "express"

[<ImportDefault("express")>]
let Express : ApplicationStatic = jsNative
