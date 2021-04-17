module Server

open Express

let application = Express.Create ()

application.``use`` (Express.``static`` "./")
application.``use`` "/" (_, res, _) -> res.sendFile ("index.html")
