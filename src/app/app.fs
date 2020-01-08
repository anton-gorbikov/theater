module App

open Fable.React
open Router

let App() =
    Router [] [
        div [] [str "Hello from Fable-React Application!"]
        Link [To "/about"] [str "About"]
        Switch [] [
            Route [Path "/about"] [str "Content of the About page!"]
            Route [Path "/"] [str "Content of the Home page!"]
        ]
    ]
