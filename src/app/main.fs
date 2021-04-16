module Main

open Fable.Core.JsInterop
open Fable.React
open App

importSideEffects "./reset.css"

let document = Browser.Dom.window.document
let root = document.getElementById "root"

ReactDom.render(App(), root)
