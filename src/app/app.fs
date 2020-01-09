module App

open Fable.Core
open Fable.React
open ReactRouter.BrowserRouter
open ReactRouter.Link
open ReactRouter.Switch
open ReactRouter.Route

let App() =
    BrowserRouter [] [
        div [] [str "Hello from Fable-React Application!"]
        Link [To (U3.Case1 "/about")] [str "About"]
        Switch [] [
            Route [Path "/about"] [str "Content of the About page!"]
            Route [Path "/"] [str "Content of the Home page!"]
        ]
    ]
