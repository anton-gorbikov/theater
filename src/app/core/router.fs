module Router

open Fable.Core
// open Fable.Helpers.React
// open Fable.Import.React
open Fable.Core.JsInterop
open Fable.React

type RouteProps =
    | Path of string
    | To of string

let inline Route (props: RouteProps list) (elems: ReactElement list): ReactElement =
    ofImport "Route" "react-router-dom" (keyValueList CaseRules.LowerFirst props) elems

let inline Switch (props: RouteProps list) (elems: ReactElement list): ReactElement =
    ofImport "Switch" "react-router-dom" (keyValueList CaseRules.LowerFirst props) elems

let inline Router (props: RouteProps list) (elems: ReactElement list): ReactElement =
    ofImport "BrowserRouter" "react-router-dom" (keyValueList CaseRules.LowerFirst props) elems

let inline Link (props: RouteProps list) (elems: ReactElement list): ReactElement =
    ofImport "Link" "react-router-dom" (keyValueList CaseRules.LowerFirst props) elems
