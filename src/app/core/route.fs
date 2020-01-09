module ReactRouter.Route

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type RouteProps =
    | Path of string

let inline Route (props: RouteProps list) (elems: ReactElement list): ReactElement =
    ofImport "Route" "react-router-dom" (keyValueList CaseRules.LowerFirst props) elems
