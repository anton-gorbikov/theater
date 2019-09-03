module Index

open Fable.React
open App

let document = Browser.Dom.window.document
let root = document.getElementById "root"

ReactDom.render(App(), root)
