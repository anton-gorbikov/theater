module Main

open Fable.Core

open express

let application = Express.Create()

application.get "/users" (fun _req res -> res.send "Users")

[<Emit("process.env.port || 3000")>]
let port : int = jsNative

application.listen port (fun () -> printf "Theater API application started")
