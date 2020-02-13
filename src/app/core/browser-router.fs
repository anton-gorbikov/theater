module ReactRouter.BrowserRouter

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type BrowserRouterProps =
    | BaseName of string
    | GetUserConfirmation of (string -> (bool -> unit) -> unit)
    | ForceRefresh of bool
    | KeyLength of int

let inline BrowserRouter (props: BrowserRouterProps list) (elems: ReactElement list): ReactElement =
    ofImport "BrowserRouter" "react-router-dom" (keyValueList CaseRules.LowerFirst props) elems
