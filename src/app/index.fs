module Server

open Fable.Core

open express

[<Import("dirname", from = "path")>]
let dirname : string -> string = jsNative

[<Import("fileURLToPath", from = "url")>]
let fileURLToPath : string -> string = jsNative

[<Emit("import.meta.url")>]
let url : string = jsNative

let __dirname = dirname (fileURLToPath url)

let application = Express.Create()

application.``use`` (Express.``static`` __dirname)
application.``use`` ("/", (fun _ res _ -> (res.sendFile (__dirname + "/index.html"))))

[<Emit("process.env.port || 4200")>]
let port : int = jsNative

application.listen port (fun () -> printf "Theater web application started")
