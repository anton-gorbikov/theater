module ReactRouter.Switch

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

let inline Switch (props: unit list) (elems: ReactElement list): ReactElement =
    ofImport "Switch" "react-router-dom" (keyValueList CaseRules.LowerFirst props) elems
