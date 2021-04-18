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

application.listen 4200 (fun () -> printf "Theater web application started")
