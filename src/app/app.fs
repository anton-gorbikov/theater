module App

open Fable.React
open Fable.Core.JsInterop

open ReactRouter.BrowserRouter
open ReactRouter.Link
open ReactRouter.Switch
open ReactRouter.Route

let App () =
    BrowserRouter []
        [ div [] [ str "Hello from Fable-React Application!" ]
          Link [ To(!^ "/about") ] [ str "About" ]
          Switch []
              [ Route [ Path "/about" ] [ str "Content of the About page!" ]
                Route [ Path "/" ] [ str "Content of the Home page!" ] ] ]
