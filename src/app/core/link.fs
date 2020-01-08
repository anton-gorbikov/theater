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

type To =
    | String of string
    | Object of ToObject
    | Function of string -> string // TODO: or string -> object

type LinkProps =
    | To of To
    | Replace of boolean

let inline Link (props: LinkProps list) (elems: ReactElement list): ReactElement =
    ofImport "Link" "react-router-dom" (keyValueList CaseRules.LowerFirst props) elems
