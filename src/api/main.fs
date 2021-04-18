module Main

open Express

let application = Express()

application.get "/users" (fun _req res -> res.send "Users")

application.listen 3000 (fun () -> printf "Hello World")
