module ReactRouter.Link

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type ToObject = {
    pathname: string
    search: string
    hash: string
    state: string
}

type LinkProps =
    | To of U3<string, ToObject, (string -> string)>
    | Replace of bool

let inline Link (props: LinkProps list) (elems: ReactElement list): ReactElement =
    ofImport "Link" "react-router-dom" (keyValueList CaseRules.LowerFirst props) elems
