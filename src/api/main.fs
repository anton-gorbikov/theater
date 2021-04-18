module Main

open express

let application = Express.Create()

application.get "/users" (fun _req res -> res.send "Users")

application.listen 3000 (fun () -> printf "Theater API application started")
