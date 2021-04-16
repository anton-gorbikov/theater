module Main

open Express

let application = Express()

application.use (Express.static "./")
application.use "/" (_, res, _) -> res.sendFile ("index.html")
