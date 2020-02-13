module ReactRouter.HashRouter

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type HashRouterProps =
    | BaseName of string
    | GetUserConfirmation of (string -> (bool -> unit) -> unit)
    | HashType of string // TODO: convert to proper type

let inline HashRouter (props: HashRouterProps list) (elems: ReactElement list): ReactElement =
    ofImport "HashRouter" "react-router-dom" (keyValueList CaseRules.LowerFirst props) elems
